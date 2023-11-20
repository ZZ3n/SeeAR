using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInfoScript : MonoBehaviour
{
    public GameObject TextInformation;
    public bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        TextInformation = GameObject.Find("TextInformation");
        isClicked = false;
        TextInformation.SetActive(false);
    }

    public void BtnClick()
    {
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
