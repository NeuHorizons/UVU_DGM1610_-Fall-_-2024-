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
    }

   
}
