using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchingBehaviours : MonoBehaviour
{
    public ID idObj; 
    public UnityEvent MatchEvent, NotMatchEvent, noMatchDelayedEvent;

   
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainersBehaviours>();
        if (tempObj == null)
            yield break;

        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            MatchEvent.Invoke();
        }
        else
        {
            NotMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}