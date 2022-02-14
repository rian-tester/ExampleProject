using UnityEngine;
using UnityEngine.UI;

public class MVPDebugger : MonoBehaviour
{
    public Text levelText;
    public Text healthText;

    [SerializeField] MVPLevel level;
    [SerializeField] MVPHealth health;
    private void Update()
    {
        Debug.Log($" Experience : {level.ExperiencePoints}, Level : {level.GetLevel()}, Health : {health.GetHealth()} ");
        healthText.text = $"Health : {health.GetHealth()}";
    }
    private void OnEnable()
    {
        level.onLevelUpAction += UpdateUI;
    }
    private void OnDisable()
    {
        level.onLevelUpAction -= UpdateUI;
    }
    public void UpdateUI()
    {
        levelText.text = $"Level : {level.GetLevel()}";

    }
}
