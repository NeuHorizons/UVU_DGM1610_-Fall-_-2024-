using UnityEngine;

public class EnemyDefeat : MonoBehaviour
{
    public LevelManager levelManager;

    public void OnEnemyDefeated()
    {
        levelManager.AddExperience(10f); // Adds 10 experience points when an enemy is defeated.
    }
}

