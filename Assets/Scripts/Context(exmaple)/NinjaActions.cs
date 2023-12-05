using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaActions : MonoBehaviour
{
    [SerializeField] private Transform player2;
    AudioManager audioManager;
    List<CustomAction> actions;
    private void Start()
    {
       audioManager = FindObjectOfType<AudioManager>();
       actions = new List<CustomAction>();
       Invoke("CompileSequence", 1.0f);
    }
    void CompileSequence()
    {
        actions.Add( new AudioAction(audioManager, "countdown", true) );
        actions.Add( new AnimateAction(GetComponent<AnimationManager>(), "Stunt", true) );
        actions.Add( new AudioAction(audioManager, "tada", true) );
        actions.Add( new CameraAction(FindObjectOfType<CameraTransition>(), player2.transform, true) );

        Sequence sequence = new Sequence(actions);
        StartCoroutine( sequence.StartSequence() );
    }
}
