using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // public GameObject ButtonEnterComment;
    // public GameObject InputComment;

    // public GameObject ScrollInput;
    // public GameObject ButtonHideComment;
    
    public GameObject ButtonInfo;
    public GameObject ButtonCapture;
    public GameObject ButtonComment;

    public bool IsClicked;

    // Start is called before the first frame update
    void Start()
    {
        ButtonsSetActive(false);
    }

    void ButtonsSetActive(bool c)
    {
        ButtonInfo.SetActive(c);
        ButtonCapture.SetActive(c);
        ButtonComment.SetActive(c);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClick()
    {
        IsClicked = !IsClicked;
        ButtonsSetActive(IsClicked);
    }
}