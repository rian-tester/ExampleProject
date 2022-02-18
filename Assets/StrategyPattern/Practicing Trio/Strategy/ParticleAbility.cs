using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAbility : ISquareAbility
{
    public void AssignAbility(SquareAbilitySystem abilitySystem)
    {
        abilitySystem.SetTheAbiltyType(this);
        UseAbility(abilitySystem);
    }

    public void UseAbility(SquareAbilitySystem abilitySystem)
    {
        abilitySystem.ParticleEffect.Play();
    }
}
