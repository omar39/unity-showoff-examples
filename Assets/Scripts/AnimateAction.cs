using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class AnimateAction : CustomAction
{
    public AnimationManager animationManager;
    float duration;
    string triggerName;
    public override bool ActionEnded()
    {
        duration -= Time.deltaTime;
        return duration <= 0;
    }

    public override void StartAction()
    {
        animationManager.StartAnimation(triggerName);
        duration = animationManager.animator.GetCurrentAnimatorClipInfo(0)[0].clip.length +
                    animationManager.animator.GetAnimatorTransitionInfo(0).duration;

        Debug.Log(duration);
    }
    public AnimateAction(AnimationManager animationManager, string triggerName, bool waitForFinish)
    {
        this.triggerName = triggerName;
        this.waitForFinish = waitForFinish;
        this.animationManager = animationManager;
    }
    
}
