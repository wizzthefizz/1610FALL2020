using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp2 : MonoBehaviour
{
   public int powerup;

   private void OnTriggerEnter(Collider other)
   {
      powerup++;
      print(powerup);
   }
}
