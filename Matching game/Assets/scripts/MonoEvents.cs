using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent awakeEvent, startEvent, onEnableEvent;
    public float holdTime = 0.1f;

    

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        startEvent.Invoke();
    }
    
    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void OnEnable()
    {
        onEnableEvent.Invoke();
    }
}