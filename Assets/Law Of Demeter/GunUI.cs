using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LawOfDemeter
{
    public class GunUI : MonoBehaviour
    {
        public void RedrawUI()
        {
            Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

            print(player.gun.ammo.roundsLeft);
        }
    }
}

