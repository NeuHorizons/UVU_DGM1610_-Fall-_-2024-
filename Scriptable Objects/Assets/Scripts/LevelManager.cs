using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public ExperienceData playerExperience;
    public LevelData LevelData;
    public Slider levelBar;

    void Start()
    {
        
    }

    public void AddExperience(float amount)
    {
        playerExperience.AddExperience(amount);

        if (playerExperience.experience >= playerExperience.experienceToNextLevel)
        {
            Debug.Log("Experience threshold reached. Calling LevelUp.");
            LevelUp();
        }
    }
    
    private void LevelUp()
    {
        Debug.Log("Leveling up... Current level: " + LevelData.level);
        playerExperience.experience = 0; // Reset experience for the new level.
        LevelData.LevelUp(); // Increase player level.
        Debug.Log("Level Up! New Level: " + LevelData.level);
    }
}
