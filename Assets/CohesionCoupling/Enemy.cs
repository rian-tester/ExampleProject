using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CohesionCoupling
{
    public class Enemy : MonoBehaviour
    {
        Character character;

        private void Start()
        {
            character = GameObject.FindObjectOfType<Character>();
        }
        public void Attack()
        {
            character.KnockBack();
            character.Shout();
            character.TakeDamage();
        }
    }
}

