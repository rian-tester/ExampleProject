using System;
using UnityEngine;


public class MVPLevel : MonoBehaviour
{
    int pointPerLevel = 200;
    int experiencePoints = 0;
    [SerializeField] int experiencePerGain;
    public int ExperiencePerGain { get => experiencePerGain; }

    [SerializeField] ParticleSystem resetHealthParticle;

    public event Action onLevelUpAction;
    public event Action onExperienceChange;

    public void GainExperience(int points)
    {
        int level = GetLevel();
        experiencePoints += points;
        onExperienceChange();
        if (GetLevel() > level)
        {
            resetHealthParticle.Play();
            if (onLevelUpAction != null)
            {
                onLevelUpAction();
            }
        }
    }
    public int GetExperience()
    {
        return experiencePoints;
    }
    public int GetLevel()
    {
        return experiencePoints / pointPerLevel;
    }
}
