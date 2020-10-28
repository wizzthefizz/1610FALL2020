using System;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
   public List<Collectible> collectibleList;

   private void Start()
   {
       for (var i = 0; i < collectibleList.Count; i++)
       {
           var position = new Vector3(i*3,0,0);
           var item = collectibleList[i];
           var newItem = new GameObject(item.name);
           newItem.transform.position = position;
           var sprite = newItem.AddComponent<SpriteRenderer>();
           sprite.sprite = item.art;
           sprite.color = item.artColor;
       }
   }
}
