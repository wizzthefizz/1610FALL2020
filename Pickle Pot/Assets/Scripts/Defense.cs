using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Defense : Collectible
{
   public float powerLevel = 0.5f;
   public GameObject art;
   public Color defenseColor;

   public override void Use()

   {
      Debug.Log(this.name);
   }
}
