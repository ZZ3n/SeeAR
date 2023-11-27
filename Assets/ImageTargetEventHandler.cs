using UnityEngine;

public class ImageTargetEventHandler : DefaultObserverEventHandler
{
    public ContentInfo contentInfo;

    protected override void Start()
    {
        base.Start();
        OnTargetFound.AddListener(OnFound);
    }

    void OnFound()
    {
        Debug.Log(this.name + "found");
        FindObjectOfType<UIManager>().UpdateTargetDescription(contentInfo);
    }
}