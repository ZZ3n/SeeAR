using TMPro;
using System;
using UnityEngine;
using UnityEngine.Serialization;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    public TMP_Text DescriptionText;
    public TMP_Text TitleText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdateTargetDescription(ContentInfo contentInfo)
    {
        DescriptionText.text = contentInfo.description;
    }
    
    public void UpdateTargetTitle(ContentInfo contentInfo)
    {
        TitleText.text = contentInfo.title;
    }
}