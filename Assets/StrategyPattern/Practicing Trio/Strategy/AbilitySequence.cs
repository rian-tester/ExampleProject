using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitySequence : ISquareAbility
{
    private ISquareAbility[] childrens;
    public AbilitySequence (ISquareAbility[] passedChildrens)
    {
        this.childrens = passedChildrens;
    }
    public void UseAbility(SquareAbilitySystem abilitySystem)
    {
        foreach (var child in childrens)
        {
            child.UseAbility(abilitySystem);
        }
    }
}
