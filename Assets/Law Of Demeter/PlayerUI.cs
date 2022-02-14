using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LawOfDemeter
{
    public class PlayerUI : MonoBehaviour
    {
        GunUI gunUI;
        
        public void RedrawUI()
        {
            Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            
            print(player.health);
            gunUI.RedrawUI(player.gun);
        }
    }
}

