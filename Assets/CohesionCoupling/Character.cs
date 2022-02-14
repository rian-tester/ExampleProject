using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CohesionCoupling
{
    public class Character : MonoBehaviour
    {
        [SerializeField] Animator animator;
        [SerializeField]AudioSource audioSource;
        [SerializeField]AudioClip shout;

        float health;

        public void KnockBack()
        {
            animator.SetTrigger("KnockBack");
        }
        public void Shout()
        {
            audioSource.PlayOneShot(shout);
        }
        public void TakeDamage()
        {
            health -= 10f;
        }
    }
}

