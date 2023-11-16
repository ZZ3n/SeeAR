using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class StartManager : MonoBehaviour
{
    public string sceneName;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        if (sceneName != null)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
            panel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}