using System;
using System.Collections;
using System.Collections.Generic;
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
        Debug.Log("Sended");
        CommentButton.onClick.AddListener(OnClick);
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {
        Debug.Log("Sended");
        UnityWebRequest www = UnityWebRequest.Get(ServerUrl);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Show results as text
            Comments fromJson = JsonUtility.FromJson<Comments>(www.downloadHandler.text);

            List<string> list = new List<string>();
            foreach (var vComment in fromJson.list)
            {
                AddComment(vComment.print());
            }

            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnClick()
    {
        string text = InputField.text;
        AddComment(text);
    }

    void AddComment(string text)
    {
        InputField.text = null;
        // int childCount = CommentList.transform.childCount;

        var item_go = Instantiate(CommentTemplate);
        item_go.GetComponentInChildren<Text>().text = text;
        item_go.transform.SetParent(CommentList);
        item_go.transform.localScale = Vector2.one;
        
        // newText.text = text;
        // newText.font = CommentTemplate.font;
        // newText.fontSize = CommentTemplate.fontSize;
        // newText.fontStyle = CommentTemplate.fontStyle;

        // RectTransform newTextRectTransform = newText.rectTransform;

        // newTextRectTransform.anchorMin = new Vector2(0, 1);
        // newTextRectTransform.anchorMax = new Vector2(1, 1);
        // newTextRectTransform.pivot = new Vector2(0, 1);

        // Vector2 commentSize = CommentTemplate.rectTransform.sizeDelta;
        // newTextRectTransform.offsetMax = new Vector2(0, -commentSize.y * childCount);
        // newTextRectTransform.offsetMin = new Vector2(0, -commentSize.y * childCount + commentSize.y);
        // newTextRectTransform.sizeDelta = new Vector2(newTextRectTransform.sizeDelta.x, commentSize.y);
    }

    [Serializable]
    public class Comment
    {
        public string name;
        public string content;

        public void printLog()
        {
            Debug.Log(print());
        }

        public string print()
        {
            return name + ":" + content;
        }
    }

    [Serializable]
    public class Comments
    {
        public List<Comment> list;
    }
}