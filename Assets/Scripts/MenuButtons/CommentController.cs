using UnityEngine;

public class CommentController : MonoBehaviour
{
    public GameObject ButtonEnterComment;
    public GameObject InputComment;
    public GameObject ScrollInput;
    public GameObject ButtonHideComment;

    // Start is called before the first frame update
    void Start()
    {
        ShowCommentComp(false);
    }
    

    public void ShowCommentComp(bool bol)
    {
        ButtonEnterComment.SetActive(bol);
        InputComment.SetActive(bol);
        ScrollInput.SetActive(bol);
        ButtonHideComment.SetActive(bol);
    }
}