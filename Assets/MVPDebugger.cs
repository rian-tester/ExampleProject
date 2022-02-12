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
    public void UpdateUI()
    {
        levelText.text = $"Level : {level.GetLevel()}";

    }
}
