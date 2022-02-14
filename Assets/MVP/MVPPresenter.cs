using UnityEngine;
using UnityEngine.UI;

public class MVPPresenter : MonoBehaviour
{
    [SerializeField] MVPLevel level;
    [SerializeField] MVPHealth health;

    [SerializeField] Text levelText;
    [SerializeField] Text experienceText;
    [SerializeField] Button increaseXPButton;
    [SerializeField] Image healthBar;

    private void Start()
    {
        UpdateLevelUI();
        increaseXPButton.onClick.AddListener(GainExperience);
        UpdateHealthUI();
    }
    private void OnEnable()
    {
        level.onExperienceChange += UpdateLevelUI;
        level.onLevelUpAction += UpdateLevelUI;
        health.onHealthChange += UpdateHealthUI;
    }
    private void OnDisable()
    {
        level.onExperienceChange -= UpdateLevelUI;
        level.onLevelUpAction -= UpdateLevelUI;
        health.onHealthChange -= UpdateHealthUI;
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
    private void UpdateHealthUI()
    {
        healthBar.fillAmount = health.GetHealth() / health.GetFullHealth();
    }
}
