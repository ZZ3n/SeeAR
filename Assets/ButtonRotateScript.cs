using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotateScript : MonoBehaviour
{
    public GameObject ButtonRotateLeft;
    public GameObject ButtonRotateRight;
    public bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        ButtonRotateLeft = GameObject.Find("ButtonRotateLeft");
        ButtonRotateRight = GameObject.Find("ButtonRotateRight");
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
        }
        else
        {
            ButtonRotateLeft.SetActive(false);
            ButtonRotateRight.SetActive(false);
        }

    }
}
