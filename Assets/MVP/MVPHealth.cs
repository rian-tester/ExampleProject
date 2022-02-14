using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVPHealth : MonoBehaviour
{
    [SerializeField] float fullHelath = 100f;
    [SerializeField] float drainPerSecond = 2f;
    float currentHealth = 0f;

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
    public void ResetHealth()
    {
        currentHealth = fullHelath;
    }
    private IEnumerator HealthDrain()
    {
        while (currentHealth > 0)
        {
            currentHealth -= drainPerSecond;
            yield return new WaitForSeconds(1);
        }
    }
}
