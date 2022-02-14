using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LawOfDemeter
{
    public class GunUI : MonoBehaviour
    {
        public void RedrawUI(Gun gun)
        {
           print(gun.GetRoundsLeft());
        }
    }
}

