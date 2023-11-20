using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuScript : MonoBehaviour
{
    public GameObject ButtonMenu;
    public GameObject ButtonRotate;
    public GameObject ButtonInfo;
    public bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        ButtonMenu = GameObject.Find("ButtonMenu");
        ButtonRotate = GameObject.Find("ButtonRotate");
        ButtonInfo = GameObject.Find("ButtonInfo");
        isClicked = false;
        ButtonRotate.SetActive(false);
        ButtonInfo.SetActive(false);
    }
    
    public void BtnClick()
    {
        isClicked = !isClicked;
        if (isClicked)
        {
            ButtonRotate.SetActive(true);
            ButtonInfo.SetActive(true);
        }
        else
        {
            ButtonRotate.SetActive(false);
            ButtonInfo.SetActive(false);
        }
        
    }
}
