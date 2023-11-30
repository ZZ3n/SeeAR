using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneScript : MonoBehaviour
{
    // Update is called once per frame
    public void SceneChange(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}