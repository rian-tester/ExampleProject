using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CohesionCoupling
{
    public class Enemy : MonoBehaviour
    {
        public void Attack(IAttackable target)
        {
            target.TakeHit();
        }
    }
    public interface IAttackable
    {
        void TakeHit();
    }
}

