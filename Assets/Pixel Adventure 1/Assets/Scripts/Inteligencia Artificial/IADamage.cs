using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IADamage : MonoBehaviour
{
    public Collider2D Collider2D;
  private void OnCollisionEnter2D (Collision2D collision)
  {
    if(collision.transform.CompareTag("Player"))
    {
      Debug.Log("DamageDone");
      collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
    }
  }
   
}
