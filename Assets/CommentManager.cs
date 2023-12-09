using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CommentManager : MonoBehaviour
{
    public Button CommentButton;

    public Transform CommentList;

    public TMP_InputField InputField;

    public GameObject CommentTemplate;

    public String ServerUrl;

    // Start is called before the first frame update

    void Start()
    {
        CommentButton.onClick.AddListener(OnClick);
        StartCoroutine(InitComments());
    }

    void OnClick()
    {
        string text = InputField.text;
        if (text == String.Empty)
        {
            return;
        }

        StartCoroutine(AddComment(text));
        StartCoroutine(PostCommentToServer(text));
    }

    public IEnumerator InitComments()
    {
        return InitComments(GetObjectName());
    }

    public IEnumerator InitComments(string objectName)
    {
        if (objectName == null)
        {
            yield break;
        }

        yield return StartCoroutine(DestroyComments());


        Debug.Log("Sended");
        UnityWebRequest www = UnityWebRequest.Get(ServerUrl + "/" + objectName);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
            yield break;
        }

        Debug.Log(www.url);
        Debug.Log(www.downloadHandler.text);

        // Show results as text
        Comments fromJson = JsonUtility.FromJson<Comments>(www.downloadHandler.text);

        List<string> list = new List<string>();
        foreach (var vComment in fromJson.list)
        {
            StartCoroutine(AddComment(vComment.print()));
        }

        // // Or retrieve results as binary data
        // byte[] results = www.downloadHandler.data;
    }

    static string GetObjectName()
    {
        return FindObjectOfType<UIManager>().TitleText.text;
    }

    IEnumerator DestroyComments()
    {
        foreach (Transform child in CommentList.transform)
        {
            Destroy(child.gameObject);
        }

        yield break;
    }

    // Update is called once per frame

    void Update()
    {
    }

    IEnumerator AddComment(string text)
    {
        InputField.text = null;
        // int childCount = CommentList.transform.childCount;

        var item_go = Instantiate(CommentTemplate);
        item_go.GetComponentInChildren<Text>().text = text;
        item_go.transform.SetParent(CommentList);
        item_go.transform.localScale = Vector2.one;
        yield break;
    }

    IEnumerator PostCommentToServer(string text)
    {
        Comment comment = new Comment();

        comment.content = text;
        comment.objectName = GetObjectName();

        var jsonString = JsonUtility.ToJson(comment);

        UnityWebRequest www = UnityWebRequest.PostWwwForm(ServerUrl, "");
        www.SetRequestHeader("Content-Type", "application/json");
        Debug.Log(jsonString);
        byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonString);

        www.uploadHandler = new UploadHandlerRaw(bodyRaw);
        www.downloadHandler = new DownloadHandlerBuffer();

        yield return www.SendWebRequest();
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.url);
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.url);
            Debug.Log(www.downloadHandler.text);
        }
    }

    [Serializable]
    public class Comment
    {
        public string objectName;
        public string content;

        public void printLog()
        {
            Debug.Log(print());
        }

        public string print()
        {
            return content;
        }
    }

    [Serializable]
    public class Comments
    {
        public List<Comment> list;
    }
}