using UnityEditorInternal;
using UnityEngine;

public class EnemyDefeat : MonoBehaviour
{
    public LevelManager levelManager;
    public float xp;
    public LevelData LevelData;
    
    
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
        LevelUp();
    }
    private void LevelUp()
    {
        Debug.Log("Leveling up... Current level: " + LevelData.level);
       
        LevelData.LevelUp(); // Increase player level.
        
        Debug.Log("Level Up! New Level: " + LevelData.level);
    }
    
}

