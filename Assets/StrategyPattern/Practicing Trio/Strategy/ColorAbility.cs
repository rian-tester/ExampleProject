using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAbility : ISquareAbility
{
    public void UseAbility(SquareAbilitySystem abilitySystem)
    {
        abilitySystem.SpriteRenderer.color = Color.red;
        // do more thing about this color
    }
}
