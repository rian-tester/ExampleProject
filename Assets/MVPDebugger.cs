using UnityEngine;
using UnityEngine.UI;

public class MVPDebugger : MonoBehaviour
{
    [SerializeField] MVPLevel level;

    [SerializeField] Text levelText;
    [SerializeField] Text experienceText;
    [SerializeField] Button increaseXPButton;

    private void Start()
    {
        UpdateLevelUI();
        increaseXPButton.onClick.AddListener(GainExperience);
    }
    private void OnEnable()
    {
        level.onExperienceChange += UpdateLevelUI;
        level.onLevelUpAction += UpdateLevelUI;
    }
    private void OnDisable()
    {
        level.onExperienceChange -= UpdateLevelUI;
        level.onLevelUpAction -= UpdateLevelUI;
    }
    private void GainExperience()
    {
        level.GainExperience(level.ExperiencePerGain); 
    }
    void UpdateLevelUI()
    {
        levelText.text = $"Level : {level.GetLevel()}";
        experienceText.text = $"Exp : {level.GetExperience()}";
    }
}
