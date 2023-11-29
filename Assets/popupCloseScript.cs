using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupCloseScript : MonoBehaviour
{
    public GameObject PopupAppInfo;
    public GameObject ButtonPopupClose;
    // Start is called before the first frame update
    void Start()
    {
        PopupAppInfo = GameObject.Find("PopupAppInfo");
        ButtonPopupClose = GameObject.Find("ButtonPopupClose");
    }

    // Update is called once per frame
    public void BtnClick()
    {
        PopupAppInfo.SetActive(false);
        ButtonPopupClose.SetActive(false);
    }
}
