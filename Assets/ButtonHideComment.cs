using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHideComment : MonoBehaviour
{
    public GameObject ButtonEnterComment;
    public GameObject InputComment;
    public GameObject ScrollInput;
    // Start is called before the first frame update
    void Start()
    {
        ButtonEnterComment = GameObject.Find("ButtonEnterComment");
        InputComment = GameObject.Find("InputComment");
        ScrollInput = GameObject.Find("ScrollInput");
    }

    // Update is called once per frame
    public void BtnClick()
    {
        ButtonEnterComment.SetActive(false);
        InputComment.SetActive(false);
        ScrollInput.SetActive(false);
    }
}
