using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayerDecorator : ISquareAbility
{
    private ISquareAbility wrappedOne;
    public DelayerDecorator (ISquareAbility strategyToWrapped)
    {
        wrappedOne = strategyToWrapped;
    }
    public async void UseAbility(SquareAbilitySystem abilitySystem)
    {
        // the decoration, in this case some delayer
        await Task.Delay (2000);
        wrappedOne.UseAbility(abilitySystem);
        Debug.Log("Particle playing after 2 seconds!");
    }
}
