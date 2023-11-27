using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCommentScript : MonoBehaviour
{
    public GameObject ButtonEnterComment;
    public GameObject InputComment;
    public GameObject ScrollInput;
    public bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        ButtonEnterComment = GameObject.Find("ButtonEnterComment");
        InputComment = GameObject.Find("InputComment");
        ScrollInput = GameObject.Find("ScrollInput");
        isClicked = false;
        ButtonEnterComment.SetActive(false);
        InputComment.SetActive(false);
        ScrollInput.SetActive(false);
    }

    public void BtnClick()
    {
        isClicked = !isClicked;
        if (isClicked)
        {
            ButtonEnterComment.SetActive(true);
            InputComment.SetActive(true);
            ScrollInput.SetActive(true);
        }
        else
        {
            ButtonEnterComment.SetActive(false);
            InputComment.SetActive(false);
            ScrollInput.SetActive(false);
        }

    }
}
