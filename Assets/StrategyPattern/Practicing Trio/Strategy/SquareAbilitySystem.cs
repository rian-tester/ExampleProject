using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareAbilitySystem : MonoBehaviour
{
    [SerializeField] InputHandler input;

    private ISquareAbility currentAbility = null;

    public ParticleSystem ParticleEffect;
    public SpriteRenderer SpriteRenderer;
    public Vector2 forwardMovement = new Vector2(3f, 0);
    public Vector2 backwardMovement = new Vector2(-3f, 0);

    private void SetTheAbilty (ISquareAbility abilityType)
    {
        currentAbility = abilityType;
        currentAbility?.UseAbility(this);
    }
    private void Blinking()
    {
        SetTheAbilty
            (new AbilitySequence(new ISquareAbility[]
            {
                new ParticleAbility(),
                new ColorAbility(),
                new DelayerDecorator (new ColorAbility())
            }));
    }
    private void BackAndForth()
    {
        SetTheAbilty(new AbilitySequence(new ISquareAbility[]
        {
            new ForwardAbility(),
            new ColorAbility(),
            new DelayerDecorator(new ColorAbility()),
            new DelayerDecorator(new BackwardAbility())

        }));
        
    }
    private void OnEnable()
    {
        input.onBlinking += Blinking;
        input.onBackAndForth += BackAndForth;
    }
    private void OnDisable()
    {
        input.onBlinking -= Blinking;
        input.onBackAndForth -= BackAndForth;
    }
}
