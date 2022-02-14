using System;
using System.Collections;
using UnityEngine;

public class MVPHealth : MonoBehaviour
{
    [SerializeField] float fullHealth = 100f;
    [SerializeField] float drainPerSecond = 2f;
    float currentHealth = 0f;

    public event Action onHealthChange;

    private void Awake()
    {
        ResetHealth();
        StartCoroutine(HealthDrain());   
    }
    private void OnEnable()
    {
        GetComponent<MVPLevel>().onLevelUpAction += ResetHealth;
    }
    private void OnDisable()
    {
        GetComponent<MVPLevel>().onLevelUpAction -= ResetHealth;
    }
    public float GetHealth()
    {
        return currentHealth;
    }
    public float GetFullHealth()
    {
        return fullHealth;
    }
    public void ResetHealth()
    {
        currentHealth = fullHealth;
        if (onHealthChange != null) onHealthChange();
    }
    private IEnumerator HealthDrain()
    {
        while (currentHealth > 0)
        {
            currentHealth -= drainPerSecond;
            if (onHealthChange != null) onHealthChange();
            yield return new WaitForSeconds(1);
        }
    }
}
