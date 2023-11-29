using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startSceneScript : MonoBehaviour
{
    public Scene nextScene;
    // Update is called once per frame
    public void SceneChange()
    {
        SceneManager.LoadScene(nextScene.name);
    }
}
