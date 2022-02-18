using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackwardAbility : ISquareAbility
{
    public void UseAbility(SquareAbilitySystem abilitySystem)
    {
        Vector2 originalPos = abilitySystem.transform.position;
        abilitySystem.transform.position = originalPos + abilitySystem.backwardMovement;
    }
}
