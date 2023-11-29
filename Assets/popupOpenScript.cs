using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupOpenScript : MonoBehaviour
{
    public GameObject PopupAppInfo;
    public GameObject ButtonPopupClose;
    // Start is called before the first frame update
    void Start()
    {
        PopupAppInfo = GameObject.Find("PopupAppInfo");
        ButtonPopupClose = GameObject.Find("ButtonPopupClose");
        PopupAppInfo.SetActive(false);
        ButtonPopupClose.SetActive(false);
    }

    // Update is called once per frame
    public void BtnClick()
    {
        PopupAppInfo.SetActive(true);
        ButtonPopupClose.SetActive(true);
    }
}
