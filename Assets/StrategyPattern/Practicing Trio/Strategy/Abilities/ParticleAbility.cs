using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAbility : ISquareAbility
{
    public void UseAbility(SquareAbilitySystem abilitySystem)
    {
        abilitySystem.ParticleEffect.Play();
    }
}
