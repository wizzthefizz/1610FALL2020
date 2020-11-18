using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Vector3Data : ScriptableObject

{
 public Vector3 value;
 
 public void SetValueFromTransform(Transform obj)
 {
  value = obj.position;
 }

 public void SetTransformFromValue(Transform obj)
 {
  obj.position = value;
 }
}
