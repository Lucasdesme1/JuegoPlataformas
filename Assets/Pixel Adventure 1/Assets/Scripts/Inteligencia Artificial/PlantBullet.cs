using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBullet : MonoBehaviour
{
   public float speed = 200;

   public float LifeTime = 2;

   public bool Left;


   private void Start()
   {
     Destroy(gameObject,LifeTime);
   }

   private void Update()
   {
     if(Left)
     {
        transform.Translate(Vector2.left*speed*Time.deltaTime); 
     }
     else
     {
          transform.Translate(Vector2.right*speed*Time.deltaTime);
     }
   }    
}


