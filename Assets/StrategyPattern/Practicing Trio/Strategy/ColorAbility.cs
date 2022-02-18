using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAbility : ISquareAbility
{
    public void UseAbility(SquareAbilitySystem abilitySystem)
    {
        bool isRed = (abilitySystem.SpriteRenderer.color == Color.red);
        if (isRed) abilitySystem.SpriteRenderer.color = Color.white;
        else abilitySystem.SpriteRenderer.color = Color.red;
        // do more thing about this color
    }
}
