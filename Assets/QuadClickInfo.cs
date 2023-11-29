using UnityEngine;

public class QuadClickInfo : MonoBehaviour
{
    public GameObject textInformation;

    private bool isClicked = false;

    void Start()
    {
        textInformation = textInformation ?? GameObject.Find("TextInformation");
        if (textInformation == null)
        {
            Debug.LogError("TextInformation game object not found in the scene");
            return;
        }

        textInformation.SetActive(false);
    }

    void OnMouseDown()
    {
        isClicked = !isClicked;
        textInformation.SetActive(isClicked);
    }
}
