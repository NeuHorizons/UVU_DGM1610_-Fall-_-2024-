using UnityEditorInternal;
using UnityEngine;

public class EnemyDefeat : MonoBehaviour
{
    public LevelManager levelManager;
    public float xp;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnEnemyDefeated();
        }
    }
    public void OnEnemyDefeated()
    {
        Debug.Log("Added XP");
        levelManager.AddExperience(xp); // Adds 10 experience points when an enemy is defeated.
    }
}

