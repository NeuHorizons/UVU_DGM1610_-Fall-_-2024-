using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchingBehaviours : MonoBehaviour
{
    public ID idObj; 
    public UnityEvent MatchEvent, NotMatchEvent;

   
    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainersBehaviours>();
        if (tempObj == null)
            return;

        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            MatchEvent.Invoke();
        }
        else
        {
            NotMatchEvent.Invoke();
        }
    }
}