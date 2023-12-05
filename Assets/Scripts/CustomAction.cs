using UnityEngine;

[System.Serializable]
public abstract class CustomAction 
{
    public bool waitForFinish;
    public abstract void StartAction();
    public abstract bool ActionEnded();
}
