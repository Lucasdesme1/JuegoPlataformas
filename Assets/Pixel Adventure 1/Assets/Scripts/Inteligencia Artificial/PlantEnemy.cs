using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEnemy : MonoBehaviour
{
   public float WaitedTime;
   public float WaitTimeAttack;
   public Animator animator;
   public GameObject BulletPrefab;
   public Transform launchSpawnPoint;

   private void Start()
   {
       
   }

   private void Update()
   {
       if(WaitedTime <= 0)
       {   
         WaitedTime = WaitTimeAttack;
        animator.Play("Attack");
            Invoke("LaunchBullet", 0.5f);
       }
       else
       {
        WaitedTime -= Time.deltaTime;
       }
   }


   public void LaunchBullet()
   {
       GameObject newbullet;
       newbullet= Instantiate(BulletPrefab,launchSpawnPoint.position,launchSpawnPoint.rotation);
   }
}
