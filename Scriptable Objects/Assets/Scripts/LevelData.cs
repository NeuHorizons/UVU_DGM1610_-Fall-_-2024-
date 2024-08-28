using UnityEngine;

[CreateAssetMenu(fileName = "NewLevelData", menuName = "ScriptableObjects/LevelData", order = 2)]
public class LevelData : ScriptableObject
{
    public int level = 1; // Initial level

    public void LevelUp()
    {
        level++; // Increment level
        Debug.Log("Level incremented, new level: " + level);
    }
}
