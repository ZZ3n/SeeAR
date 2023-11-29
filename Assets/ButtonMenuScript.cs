using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuScript : MonoBehaviour
{
    public GameObject ButtonMenu;
    public GameObject ButtonRotate;
    public GameObject ButtonInfo;
    public GameObject ButtonCapture;
    public GameObject ButtonComment;
    private bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
        ButtonRotate.SetActive(false);
        ButtonInfo.SetActive(false);
        ButtonCapture.SetActive(false);
        ButtonComment.SetActive(false);
    }
    
    public void BtnClick()
    {
        isClicked = !isClicked;
        if (isClicked)
        {
            ButtonRotate.SetActive(true);
            ButtonInfo.SetActive(true);
            ButtonCapture.SetActive(true);
            ButtonComment.SetActive(true);
        }
        else
        {
            ButtonRotate.SetActive(false);
            ButtonInfo.SetActive(false);
            ButtonCapture.SetActive(false);
            ButtonComment.SetActive(false);
        }
        
    }
}
