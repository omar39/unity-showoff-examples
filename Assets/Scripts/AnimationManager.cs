using System;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator animator;
    
    public void StartAnimation(string name)
    {
        animator.SetTrigger(name);
    }
}
