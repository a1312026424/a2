using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
   public GameObject human;
   public float value;
   public Vector3 sizeChange;

   public void MoveLeft()
   {
      value = value - 0.5f;
      human.transform.position = new Vector3(value + 4 , 2, -26);

   }

   public void MoveRight()
   {
      value = value + 0.5f;
      human.transform.position = new Vector3(value + 4 , 2, -26);
   }

   public void RotateLeft()
   {
      human.transform.Rotate(20f, 0f, 0f);
   }

   public void RotateRight()
   {
      human.transform.Rotate(0f, 20f, 0f);
   }

   public void Grow()
   {
      human.transform.localScale = human.transform.localScale + sizeChange;
   }

   public void Shrink()
   {
      human.transform.localScale = human.transform.localScale - sizeChange;
   }

   public void ResetHuman()
   {
      human.transform.position = new Vector3(4, 2,-26);
      human.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
      human.transform.localScale = new Vector3(1,1,1);
   }



}
