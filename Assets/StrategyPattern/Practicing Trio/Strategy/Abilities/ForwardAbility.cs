using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardAbility : ISquareAbility
{
    public void UseAbility(SquareAbilitySystem abilitySystem)
    {
        Vector2 originalPos = abilitySystem.transform.position;
        abilitySystem.transform.position = originalPos + abilitySystem.forwardMovement;
    }
}
