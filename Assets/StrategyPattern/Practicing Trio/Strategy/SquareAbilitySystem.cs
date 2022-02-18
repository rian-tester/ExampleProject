using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareAbilitySystem : MonoBehaviour
{
    private ISquareAbility currentAbility = null;

    public ParticleSystem ParticleEffect;
    public SpriteRenderer SpriteRenderer;

    public void SetTheAbiltyType (ISquareAbility abilityType)
    {
        currentAbility = abilityType;
        currentAbility?.UseAbility(this);
    }
}
