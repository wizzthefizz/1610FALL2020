using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DefenseSwitch : ScriptableObject
{
   public enum Defences
   {
      Shield,
      Potions,
      ExtraHealth,
      Buffs,
      SuperShield,
      
   }

   public Defences currentDefense;

   public void RunCurrentDefense()
   {
      switch (currentDefense)
      {
         case Defences.Shield:
            //function
            break;
         case Defences.Potions:
            //function
            break;
         case Defences.ExtraHealth:
            //function
            break;
         case Defences.Buffs:
            //function
            break;
         case Defences.SuperShield:
            //function
            break;
      }
   }
}
