using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Events;
public class EnemyDefeat : MonoBehaviour
{
    [SerializeField] private UnityEvent Xp;
    public LevelManager levelManager;
    public float xp;
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Xp.Invoke();
            OnEnemyDefeated();
        }
    }
    public void OnEnemyDefeated()
    {
        Debug.Log("Added XP");
        levelManager.AddExperience(xp); // Adds 10 experience points when an enemy is defeated.
        
    }
    
    
}

