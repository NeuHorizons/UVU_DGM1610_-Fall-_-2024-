using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    // UnityEvents for various MonoBehaviour events
    public UnityEvent awakeEvent, startEvent, onEnableEvent;
    public UnityEvent onTriggerEnterEvent, onTriggerExitEvent;
    public UnityEvent onCollisionEnterEvent, onCollisionExitEvent;

    // Additional UnityEvent for teleporting
    public UnityEvent teleportEvent;

    // Time to wait before invoking Start event
    public float holdTime = 0.1f;

    // Called when the object awakes
    private void Awake()
    {
        awakeEvent.Invoke();
    }

    // Called when the object is enabled
    private void OnEnable()
    {
        onEnableEvent.Invoke();
    }

    // Called after a delay at the start
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        startEvent.Invoke();
    }

    // Called when a collider marked as a trigger enters this object's collider
    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnterEvent.Invoke();
    }

    // Called when a collider marked as a trigger exits this object's collider
    private void OnTriggerExit(Collider other)
    {
        onTriggerExitEvent.Invoke();
    }

    // Called when another collider makes contact with this object's collider
    private void OnCollisionEnter(Collision collision)
    {
        onCollisionEnterEvent.Invoke();
    }

    // Called when another collider stops making contact with this object's collider
    private void OnCollisionExit(Collision collision)
    {
        onCollisionExitEvent.Invoke();
    }

    // Call this method to trigger teleport
    public void TriggerTeleport()
    {
        teleportEvent.Invoke();
    }
}