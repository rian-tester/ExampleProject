using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public event Action onAbilityOne;
    public event Action onAbilityTwo;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (onAbilityOne != null) onAbilityOne();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (onAbilityTwo != null) onAbilityTwo();
        }
    }
}
