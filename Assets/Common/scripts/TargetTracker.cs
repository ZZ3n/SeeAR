using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetTracker : MonoBehaviour
{
    ObserverBehaviour imageTargetBehaviour;
    Vector3 initLocalScale;

    GameObject cube;

    SpriteRenderer spriteRenderer;
    Color32 initColor;
    byte r, g, b;

    void Start()
    {
        initLocalScale = this.transform.localScale;

        cube = this.transform.GetChild(0).gameObject;
        cube.SetActive(false);

        spriteRenderer = this.GetComponent<SpriteRenderer>();
        initColor = spriteRenderer.material.color;
        r = initColor.r;
        g = initColor.g;
        b = initColor.b;

        imageTargetBehaviour = this.GetComponentInParent<ObserverBehaviour>();
        imageTargetBehaviour.OnTargetStatusChanged += onTargetStatusChanged;
    }

    private IEnumerator makeAROutLine()
    {
        float size = 5.0f;
        this.transform.localScale = initLocalScale * size;

        while (size >= 1.0f)
        {
            size -= 0.025f;
            this.transform.localScale = initLocalScale * size;

            yield return null;
        }
    }

    private void OnMouseDown()
    {
        cube.SetActive(true);
    }

    void onTargetStatusChanged(ObserverBehaviour observerbehavour, TargetStatus status)
    {
        if (status.Status == Status.TRACKED && status.StatusInfo == StatusInfo.NORMAL)
        {
            Debug.Log("Get Target Image!");
            this.gameObject.SetActive(true);
            StartCoroutine(makeAROutLine());
        }

        if (status.Status == Status.EXTENDED_TRACKED && status.StatusInfo == StatusInfo.NORMAL)
        {
            Debug.Log("Miss Target Image!");
            this.gameObject.SetActive(false);
            cube.SetActive(false);
        }
    }

    private void Update()
    {
        r += 4; g -= 3; b += 2;

        spriteRenderer.material.color 
            = new Color32((byte)(r % 256), (byte)(g % 256), (byte)(b % 256), 255);
    }
}