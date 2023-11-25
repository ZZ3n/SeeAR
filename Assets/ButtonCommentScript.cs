using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCommentScript : MonoBehaviour
{
    public GameObject ButtonEnterComment;
    public GameObject InputComment;
    public bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        ButtonEnterComment = GameObject.Find("ButtonEnterComment");
        InputComment = GameObject.Find("InputComment");
        isClicked = false;
        ButtonEnterComment.SetActive(false);
        InputComment.SetActive(false);
    }

    public void BtnClick()
    {
        isClicked = !isClicked;
        if (isClicked)
        {
            ButtonEnterComment.SetActive(true);
            InputComment.SetActive(true);
        }
        else
        {
            ButtonEnterComment.SetActive(false);
            InputComment.SetActive(false);
        }

    }
}
