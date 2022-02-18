using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAbility : ISquareAbility
{
    public void AssignAbility (SquareAbilitySystem abilitySystem)
    {
        abilitySystem.SetTheAbiltyType(this);
        UseAbility (abilitySystem);
    }
    public void UseAbility(SquareAbilitySystem abilitySystem)
    {
        abilitySystem.SpriteRenderer.color = Color.red;
        // do more thing about this color
    }
}
