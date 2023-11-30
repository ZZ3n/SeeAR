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
        if (Application.isEditor)
        {
            CaptureInEditor(cam);
            return;
        }

        CaptureInFlight(cam);
    }

    void CaptureInFlight(Camera cam)
    {
        string fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";
        byte[] byteArray = MakeScreenShot(cam);
        NativeGallery.SaveImageToGallery(byteArray, "album", fileName,
            (success, s) =>
            {
                if (success)
                {
                    Debug.Log("SCREENSHOT! Path : " + s);
                }
                else
                {
                    Debug.Log("Failed! Path : " + s);
                }
            }
        );
    }

    void CaptureInEditor(Camera cam)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        string fileName = path + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";
        byte[] byteArray = MakeScreenShot(cam);

        File.WriteAllBytes(fileName, byteArray);
        Debug.Log("SCREENSHOT! Path : " + path);
    }

    byte[] MakeScreenShot(Camera cam)
    {
        RenderTexture screenTexture = new RenderTexture(Screen.width, Screen.height, 16);
        RenderTexture temp = cam.targetTexture;
        cam.targetTexture = screenTexture;
        RenderTexture.active = screenTexture;
        cam.Render();
        Texture2D renderedTexture = new Texture2D(Screen.width, Screen.height);
        renderedTexture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        RenderTexture.active = null;
        cam.targetTexture = temp;

        return renderedTexture.EncodeToPNG();
    }
}