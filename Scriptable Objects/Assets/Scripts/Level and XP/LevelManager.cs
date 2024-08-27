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

        if (playerExperience.experience >= playerExperience.experienceToNextLevel)
        {
            LevelUp();
        }
    }

    private void UpdateLevelBar()
    {
        levelBar.value = playerExperience.GetExperiencePercentage();
    }

    private void LevelUp()
    {
        playerExperience.experience = 0; // Reset experience for the new level.
        playerLevel.LevelUp();
        // You might want to increase the `experienceToNextLevel` for the new level.
        playerExperience.experienceToNextLevel *= 1.2f; // Example of making it more challenging.
        UpdateLevelBar();
        Debug.Log("Level Up! New Level: " + playerLevel.level);
    }
}