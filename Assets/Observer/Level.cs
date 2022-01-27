using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour {

    [SerializeField] int pointsPerLevel = 200;
    int experiencePoints = 0;

    [SerializeField] UnityEvent onLevelUp;

    public event Action onLevelUpAction;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(.2f);
            GainExperience(10);
        }
    }

    public void GainExperience(int points)
    {
        int level = GetLevel();
        experiencePoints += points;

        if (GetLevel() > level )
        {
            onLevelUp.Invoke();
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
        return experiencePoints / pointsPerLevel;
    }
}