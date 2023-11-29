using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ContentInfo
{
    [TextArea(1, 100)] public string title;
    [TextArea(3, 10)] public string description;
}