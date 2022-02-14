using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using System;


public class MVPLevel : MonoBehaviour
{
    int pointPerLevel = 200;
    int experiencePoints = 0;
    public int ExperiencePoints { get => experiencePoints;}
    [SerializeField] int experiencePerGain;
    [SerializeField] private float secondsForExperince;

    public UnityEvent onLevelUp;

    public event Action onLevelUpAction;

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(secondsForExperince);
            GainExperience(experiencePerGain);
        }
    }
    public void GainExperience(int points)
    {
        int level = GetLevel();
        experiencePoints += points;
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
