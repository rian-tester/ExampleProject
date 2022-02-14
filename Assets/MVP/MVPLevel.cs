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
    //[SerializeField] private float secondsForExperince;

    [SerializeField] Text levelText;
    [SerializeField] Text experienceText;
    [SerializeField] Button increaseXPButton;



    public UnityEvent onLevelUp;

    public event Action onLevelUpAction;

    private void Start()
    {
        UpdateUI();
        increaseXPButton.onClick.AddListener(() => GainExperience(experiencePerGain));
    }
    public void UpdateUI()
    {
        levelText.text = $"Level : {GetLevel()}";
        experienceText.text = $"Exp : {GetExperience()}";

    }
    public void GainExperience(int points)
    {
        int level = GetLevel();
        experiencePoints += points;
        UpdateUI();
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
