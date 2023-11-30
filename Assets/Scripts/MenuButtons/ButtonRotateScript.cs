using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotateScript : MonoBehaviour
{
    public GameObject ButtonRotateLeft;
    public GameObject ButtonRotateRight;
    bool isClicked;

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
        ButtonRotateLeft.SetActive(isClicked);
        ButtonRotateRight.SetActive(isClicked);
    }
}