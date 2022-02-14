using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CohesionCoupling
{
    public class Character : MonoBehaviour, IAttackable
    {
        [SerializeField] Animator animator;
        [SerializeField]AudioSource audioSource;
        [SerializeField]AudioClip shout;

        float health;
        public void TakeHit()
        {
            animator.SetTrigger("KnockBack");
            audioSource.PlayOneShot(shout);
            health -= 10f;
        }
    }
}

