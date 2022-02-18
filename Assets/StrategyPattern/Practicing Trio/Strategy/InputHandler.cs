using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public event Action onBlinking;
    public event Action onBackAndForth;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (onBlinking != null) onBlinking();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (onBackAndForth != null) onBackAndForth();
        }
    }
}
