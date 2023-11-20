using System;
using System.IO;
using UnityEngine;
using Vuforia;

public class CaptureButtonManager : MonoBehaviour
{
    string path;

    // Use this for initialization
    void Start()
    {
        path = Application.dataPath + "/ScreenShot/";
        Debug.Log(path);
    }

    public void SaveCameraView(Camera cam)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        string fileName = path + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";

        RenderTexture screenTexture = new RenderTexture(Screen.width, Screen.height, 16);
        RenderTexture temp = cam.targetTexture;
        cam.targetTexture = screenTexture;
        RenderTexture.active = screenTexture;
        cam.Render();
        Texture2D renderedTexture = new Texture2D(Screen.width, Screen.height);
        renderedTexture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        RenderTexture.active = null;
        byte[] byteArray = renderedTexture.EncodeToPNG();
        File.WriteAllBytes(fileName, byteArray);
        Debug.Log("SCREENSHOT! Path : " + path);
        cam.targetTexture = temp;
    }
}