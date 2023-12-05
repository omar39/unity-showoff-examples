using UnityEngine;

public class CameraAction : CustomAction
{
    CameraTransition  cameraTransition;
    Transform target;
    public override bool ActionEnded()
    {
        return cameraTransition.hasEndedJob;
    }

    public override void StartAction()
    {
        cameraTransition.StartTransition(target);
    }
    public CameraAction(CameraTransition cameraTransition, Transform target, bool waitForFinish)
    {
        this.cameraTransition = cameraTransition;
        this.target = target;
        this.waitForFinish = waitForFinish;
    }
}
