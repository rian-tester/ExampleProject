using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LawOfDemeter
{
    public class Gun : MonoBehaviour
    {
        public Ammo ammo;

        public int GetRoundsLeft()
        {
            return ammo.roundsLeft;
        }
    }
}

