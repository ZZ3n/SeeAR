using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CommentManager : MonoBehaviour
{
    public Button CommentButton;

    public GameObject CommentList;

    public TMP_InputField InputField;

    public Text CommentTemplate;

    // Start is called before the first frame update
    void Start()
    {
        CommentButton.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnClick()
    {
        string text = InputField.text;
        InputField.text = null;
        int childCount = CommentList.transform.childCount;

        var go = new GameObject();
        go.transform.parent = CommentList.transform;

        var newText = go.AddComponent<Text>();

        newText.text = text;
        newText.font = CommentTemplate.font;
        newText.fontSize = CommentTemplate.fontSize;
        newText.fontStyle = CommentTemplate.fontStyle;

        RectTransform newTextRectTransform = newText.rectTransform;

        newTextRectTransform.anchorMin = new Vector2(0, 1);
        newTextRectTransform.anchorMax = new Vector2(1, 1);
        newTextRectTransform.pivot = new Vector2(0, 1);

        Vector2 commentSize = CommentTemplate.rectTransform.sizeDelta;
        newTextRectTransform.offsetMax = new Vector2(0, -commentSize.y * childCount);
        newTextRectTransform.offsetMin = new Vector2(0, -commentSize.y * childCount + commentSize.y);
        newTextRectTransform.sizeDelta = new Vector2(newTextRectTransform.sizeDelta.x, commentSize.y);
    }
}