using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public ExperienceData playerExperience;
    public LevelData playerLevel;
    public Slider levelBar;

    void Start()
    {
        UpdateLevelBar();
    }

    public void AddExperience(float amount)
    {
        playerExperience.AddExperience(amount);
        UpdateLevelBar();
        Debug.Log("Added experience: " + amount + ", Total experience: " + playerExperience.experience);

        if (playerExperience.experience >= playerExperience.experienceToNextLevel)
        {
            Debug.Log("Experience threshold reached. Calling LevelUp.");
            LevelUp();
        }
        else
        {
            Debug.Log("Experience not enough to level up. Current experience: " + playerExperience.experience);
        }
    }


    private void UpdateLevelBar()
    {
        levelBar.value = playerExperience.GetExperiencePercentage();
        Debug.Log("Updated level bar: " + levelBar.value);
    }

    private void LevelUp()
    {
        Debug.Log("Leveling up... Current level: " + playerLevel.level);
        playerExperience.experience = 0; // Reset experience for the new level.
        playerLevel.LevelUp(); // Increase player level.
        UpdateLevelBar();
        Debug.Log("Level Up! New Level: " + playerLevel.level);
    }
}
