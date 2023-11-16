using System;
using System.IO;
using UnityEngine;

public class CaptureButtonManager : MonoBehaviour
{
    string path;
    public Camera Cam;

    // Use this for initialization
    void Start()
    {
        path = Application.dataPath + "/ScreenShot/";
        Debug.Log(path);
    }

    public void CamCapture()
    {
        string fileName = path + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";
        RenderTexture currentRT = RenderTexture.active;
        RenderTexture.active = Cam.targetTexture;

        Cam.Render();

        Texture2D Image = new Texture2D(Cam.targetTexture.width, Cam.targetTexture.height);
        Image.ReadPixels(new Rect(0, 0, Cam.targetTexture.width, Cam.targetTexture.height), 0, 0);
        Image.Apply();
        
        RenderTexture.active = currentRT;

        var Bytes = Image.EncodeToPNG();
        Destroy(Image);

        File.WriteAllBytes(fileName, Bytes);
        Debug.Log("SCREEN CAPTURED, Path: " + fileName);
    }
}