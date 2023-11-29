using UnityEngine;

public class ButtonInfoScript : MonoBehaviour
{
    public GameObject TextInformation;

    bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
        TextInformation.SetActive(false);
    }

    public void BtnClick()
    {
        isClicked = !isClicked;
        TextInformation.SetActive(isClicked);
    }
}