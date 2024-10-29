using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "GameActions/DieAction")]
public class GameAction : ScriptableObject
{
    public event System.Action OnStartEvent;
    public event System.Action OnRespondEvent;
    public event System.Action OnDelayedRespondEvent;

    // Call this method to activate the action
    public void Activate(float delay = 0f)
    {
        // Trigger the StartEvent when activation begins
        OnStartEvent?.Invoke();
        
        // If delay is zero, trigger the RespondEvent immediately
        if (delay <= 0)
        {
            OnRespondEvent?.Invoke();
        }
        else
        {
            // Otherwise, start the delayed response coroutine
            GameActionManager.Instance.StartCoroutine(DelayedResponseCoroutine(delay));
        }
    }

    // Coroutine to trigger the delayed response
    private IEnumerator DelayedResponseCoroutine(float delay)
    {
        yield return new WaitForSeconds(delay);
        OnRespondEvent?.Invoke();
        OnDelayedRespondEvent?.Invoke();
    }
}