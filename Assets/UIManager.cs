using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text DescriptionText;
    public TMP_Text TitleText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdateTargetDescription(ContentInfo contentInfo)
    {
        if (TitleText.text != contentInfo.title)
        {
            DescriptionText.text = contentInfo.description;
            TitleText.text = contentInfo.title;
            CommentManager commentManager = FindObjectOfType<CommentManager>();
            StartCoroutine(commentManager.InitComments(contentInfo.title));
        }
    }
}