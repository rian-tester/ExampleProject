using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareAbilitySystem : MonoBehaviour
{
    [SerializeField] InputHandler input;

    private ISquareAbility currentAbility = null;

    public ParticleSystem ParticleEffect;
    public SpriteRenderer SpriteRenderer;
    public Vector2 forward = new Vector2(3f, 0);
    public Vector2 vector2 = new Vector2(-3f, 0);

    private void SetTheAbiltyType (ISquareAbility abilityType)
    {
        currentAbility = abilityType;
        currentAbility?.UseAbility(this);
    }
    private void Blinking()
    {
        SetTheAbiltyType
            (new AbilitySequence(new ISquareAbility[]
            {
                new ParticleAbility(),
                new ColorAbility(),
                new DelayerDecorator (new ColorAbility())
            }));
    }
    private void OnEnable()
    {
        input.onBlinking += Blinking;
    }
    private void OnDisable()
    {
        
    }
}
