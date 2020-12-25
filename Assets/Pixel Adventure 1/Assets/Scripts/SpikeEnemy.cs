using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeEnemy : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D collision)
     {
         if (collision.CompareTag("Player"))
         {
             Debug.Log("DamageDone");
             collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
         }
     }
}
