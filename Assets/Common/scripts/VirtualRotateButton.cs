using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualRotateButton : MonoBehaviour
{
    public GameObject cube;
    VirtualButtonBehaviour vBB;

    float rotateSpeed = 300.0f;
    bool rotating = false;

    void Start()
    {
        vBB = this.GetComponent<VirtualButtonBehaviour>();

        vBB.RegisterOnButtonPressed(rotateCube);
        vBB.RegisterOnButtonReleased(stopCube);
    }

    public void rotateCube(VirtualButtonBehaviour vb)
    {
        rotating = true;
    }

    public void stopCube(VirtualButtonBehaviour vb)
    {
        rotating = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(rotating)
        {
            cube.transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
        }
    }
}