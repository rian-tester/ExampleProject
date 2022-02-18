using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareAbilitySystem : MonoBehaviour
{
    private ISquareAbility currentAbility = null;
    [SerializeField] private InputHandler input;

    public ParticleSystem ParticleEffect;
    public SpriteRenderer SpriteRenderer = null;

    private void UseParticle()
    {
        currentAbility = new ParticleAbility();
        currentAbility.UseAbility(this);
    }
    private void ChangeColor()
    {
        currentAbility.UseAbility(this);
    }
    private void OnEnable()
    {
        input.onAbilityOne += UseParticle;   
    }
    private void OnDisable()
    {
        input.onAbilityOne -= UseParticle;
    }
}
