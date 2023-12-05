using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence
{
    List<CustomAction> actions;
    public Sequence (List<CustomAction> actions)
    {
        this.actions = actions;
    }
    public IEnumerator StartSequence()
    {
        return SequenceCorutine() ;
    }
    IEnumerator SequenceCorutine()
    {
        foreach(CustomAction action in actions)
        {
            action.StartAction();

            yield return new WaitUntil( () => action.waitForFinish && action.ActionEnded() );
        }
    }

}
