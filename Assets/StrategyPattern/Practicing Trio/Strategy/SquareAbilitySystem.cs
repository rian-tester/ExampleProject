using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareAbilitySystem : MonoBehaviour
{
    private ISquareAbility currentAbility = null;
    [SerializeField] private InputHandler input;

    public ParticleSystem ParticleEffect;
    public SpriteRenderer SpriteRenderer;

    private void UseParticle()
    {
        currentAbility = new ParticleAbility();
        currentAbility.UseAbility(this);
    }
    private void ChangeColor()
    {
        currentAbility = new ColorAbility();
        currentAbility.UseAbility(this);
        StartCoroutine(RevertColor());
    }
    private void OnEnable()
    {
        input.onAbilityOne += UseParticle;
        input.onAbilityTwo += ChangeColor;
    }
    private void OnDisable()
    {
        input.onAbilityOne -= UseParticle;
        input.onAbilityTwo += ChangeColor;
    }
    IEnumerator RevertColor()
    {
        yield return new WaitForSeconds(1.0f);
        SpriteRenderer.color = Color.white;
        //revert more thing about color
        StopAllCoroutines();
    }
}
