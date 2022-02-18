using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] SquareAbilitySystem abilitySystem;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            abilitySystem.SetTheAbiltyType(new ParticleAbility());
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            abilitySystem.SetTheAbiltyType(new ColorAbility());
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            abilitySystem.SetTheAbiltyType
                (
                    new DelayerDecorator 
                    (
                        new ParticleAbility()
                    )
                );
        }
    }
}
