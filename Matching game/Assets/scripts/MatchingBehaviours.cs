using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchingBehaviours : MonoBehaviour
{
    public ID idObj;

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<IDContainersBehaviours>().idObj;
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
    }
}
