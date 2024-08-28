using UnityEngine;

[CreateAssetMenu(fileName = "NewExperienceData", menuName = "ScriptableObjects/ExperienceData", order = 1)]
public class ExperienceData : ScriptableObject
{
    public float experience;
    public float experienceToNextLevel;

    public void AddExperience(float amount)
    {
        experience += amount;
        Debug.Log("Current experience: " + experience + " / " + experienceToNextLevel);

        if (experience >= experienceToNextLevel)
        {
            experience -= experienceToNextLevel; // Carry over the excess experience
            Debug.Log("Experience carried over, new experience: " + experience);
            // Optionally increase the experience required for the next level.
            // experienceToNextLevel += someValue;
        }
    }

    public float GetExperiencePercentage()
    {
        return experience / experienceToNextLevel;
    }
}
