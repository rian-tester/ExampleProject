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
    public void UseAbility(SquareAbilitySystem abilitySystem)
    {
        // the decoration, in this case some delayer
        Task.Delay(2500);
        wrappedOne.UseAbility(abilitySystem);

    }
}
