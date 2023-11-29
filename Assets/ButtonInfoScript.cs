using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInfoScript : MonoBehaviour
{
    public GameObject TextInformation;
    public GameObject ButtonRotate;
    public GameObject ButtonInfo;
    public GameObject ButtonCapture;
    public GameObject ButtonComment;
    private bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
        TextInformation.SetActive(false);
    }

    public void BtnClick()
    {
        ButtonRotate.SetActive(false);
        ButtonInfo.SetActive(false);
        ButtonCapture.SetActive(false);
        ButtonComment.SetActive(false);

        isClicked = !isClicked;
        if (isClicked)
        {
            TextInformation.SetActive(true);
        }
        else
        {
            TextInformation.SetActive(false);
        }

    }
}
