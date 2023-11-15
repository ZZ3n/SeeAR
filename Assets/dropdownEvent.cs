using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // ⭐⭐

public class ObjectDropdownEvent : MonoBehaviour
{
     public GameObject title;

    void Start()
    {
        title = GameObject.Find("title");
    }

    public void DropdownEvent(int index)
    {
        Color color = Color.white;

        switch (index)
        {
            case 0:
                gameObject.SetActive(false);
                break;
            case 1:
                gameObject.SetActive(true);
                break;
            case 2:
                title.SetActive(false);
                break;
            case 3:
                title.SetActive(true);
                break;
            case 4:
                color = Color.green;
                break;
            case 5:
                color = Color.white;
                break;
        }

        GetComponent<Renderer>().material.color = color;
    }
}