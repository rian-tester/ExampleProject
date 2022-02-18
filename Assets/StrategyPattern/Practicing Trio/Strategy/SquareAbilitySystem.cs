using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareAbilitySystem : MonoBehaviour
{
    private ISquareAbility currentAbility = null;

    public ParticleSystem ParticleEffect;
    public SpriteRenderer SpriteRenderer;

    public void SetTheAbiltyType (ISquareAbility abilityType)
    {
        currentAbility = abilityType;
        RunTheAbility();
    }
    private void RunTheAbility()
    {
        currentAbility?.UseAbility(this);
    }
    IEnumerator RevertColor()
    {
        yield return new WaitForSeconds(1.0f);
        SpriteRenderer.color = Color.white;
        //revert more thing about color
        StopAllCoroutines();
    }
}
