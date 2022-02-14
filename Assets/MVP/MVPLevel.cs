using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class MVPLevel : MonoBehaviour
{
    int pointPerLevel = 200;
    int experiencePoints = 0;
    [SerializeField] int experiencePerGain;
    public int ExperiencePerGain { get => experiencePerGain; }
    //[SerializeField] private float secondsForExperince;

    public UnityEvent onLevelUp;

    public event Action onLevelUpAction;
    public event Action onExperienceChange;

    public void GainExperience(int points)
    {
        int level = GetLevel();
        experiencePoints += points;
        onExperienceChange();
        if (GetLevel() > level)
        {
            onLevelUp.Invoke ();
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
