using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotateScript : MonoBehaviour
{
    public GameObject ButtonRotateLeft;
    public GameObject ButtonRotateRight;
    public GameObject ButtonRotate;
    public GameObject ButtonInfo;
    public GameObject ButtonCapture;
    public GameObject ButtonComment;
    public bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
        ButtonRotateLeft.SetActive(false);
        ButtonRotateRight.SetActive(false);
    }

    public void BtnClick()
    {
        isClicked = !isClicked;
        if (isClicked)
        {
            ButtonRotateLeft.SetActive(true);
            ButtonRotateRight.SetActive(true);
            ButtonRotate.SetActive(false);
            ButtonInfo.SetActive(false);
            ButtonCapture.SetActive(false);
            ButtonComment.SetActive(false);
        }
        else
        {
            ButtonRotateLeft.SetActive(false);
            ButtonRotateRight.SetActive(false);
            ButtonRotate.SetActive(false);
            ButtonInfo.SetActive(false);
            ButtonCapture.SetActive(false);
            ButtonComment.SetActive(false);
        }

    }
}
