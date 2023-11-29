using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCommentScript : MonoBehaviour
{
    public GameObject ButtonEnterComment;
    public GameObject InputComment;
    public GameObject ScrollInput;
    public GameObject ButtonHideComment;
    public GameObject ButtonRotate;
    public GameObject ButtonInfo;
    public GameObject ButtonCapture;
    public GameObject ButtonComment;

    // Start is called before the first frame update
    void Start()
    {
        ButtonEnterComment.SetActive(false);
        InputComment.SetActive(false);
        ScrollInput.SetActive(false);
        ButtonHideComment.SetActive(false);
    }

    public void BtnClick()
    {
        ButtonEnterComment.SetActive(true);
        InputComment.SetActive(true);
        ScrollInput.SetActive(true);
        ButtonHideComment.SetActive(true);
        ButtonRotate.SetActive(false);
        ButtonInfo.SetActive(false);
        ButtonCapture.SetActive(false);
        ButtonComment.SetActive(false);
    }
}
