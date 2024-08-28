using UnityEngine;

[CreateAssetMenu(fileName = "NewExperienceData", menuName = "ScriptableObjects/ExperienceData", order = 1)]
public class ExperienceData : ScriptableObject
{
    public float experience;
    public float experienceToNextLevel;

    public void AddExperience(float amount)
    {
        experience += amount;
        if (experience >= experienceToNextLevel)
        {
            experience -= experienceToNextLevel;
            // Consider increasing the experienceToNextLevel for the next level, making leveling up more challenging.
        }
    }

    public float GetExperiencePercentage()
    {
        return experience / experienceToNextLevel;
    }
}