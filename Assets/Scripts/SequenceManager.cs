using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class SequenceManager : MonoBehaviour
{
    List<CustomAction> actions = new List<CustomAction>();
    IEnumerator StartSequenceCoroutine()
    {
        yield return null;
    }
    public void StartSequence()
    {
        StartCoroutine( StartSequenceCoroutine() );
    }
}
