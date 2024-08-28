using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public ExperienceData playerExperience;
    public LevelData LevelData;
    public Slider levelBar;
    public Text levelText;

    void Start()
    {
        // Set the slider's max value to the experience needed for the next level
        levelBar.maxValue = playerExperience.experienceToNextLevel;
        levelBar.value = playerExperience.experience;
        UpdateLevelText();
    }

    public void AddExperience(float amount)
    {
        playerExperience.AddExperience(amount);

        if (playerExperience.experience >= playerExperience.experienceToNextLevel)
        {
            Debug.Log("Experience threshold reached. Calling LevelUp.");
            LevelUp();
        }
        levelBar.value = playerExperience.experience;
    }
    
    private void LevelUp()
    {
        Debug.Log("Leveling up... Current level: " + LevelData.level);
        playerExperience.experience = 0; // Reset experience for the new level.
        LevelData.LevelUp(); // Increase player level.
        Debug.Log("Level Up! New Level: " + LevelData.level);
        
        // Reset the slider for the new level.
        levelBar.maxValue = playerExperience.experienceToNextLevel;
        levelBar.value = playerExperience.experience;
        
        UpdateLevelText();
    }
    private void UpdateLevelText()
    {
        // This updates the levelText to show the current level
        levelText.text = "Level: " + LevelData.level.ToString();
    }
}
