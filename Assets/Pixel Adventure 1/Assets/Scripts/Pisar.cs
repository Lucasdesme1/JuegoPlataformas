using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pisar : MonoBehaviour
{
    public Collider2D collider2d;
    public Animator Anim;

    public SpriteRenderer Sprite;

    public GameObject destroyParticle;

    public float JumpForce = 2.5f;

    public int lifes = 2;


    private void OnCollisionEnter2D(Collision2D collision)
    {
     if(collision.transform.CompareTag("Player"))
     {
      collision.gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up * JumpForce);
       Anim.Play("Hit");
      Destroy(gameObject, 0.2f);
     }

    }
 public void LoseLifeAndHit()
 {
    lifes--;
    Anim.Play("Hit");
 }

 public void CheckLife()
 {
    if(lifes==0)
    {
        destroyParticle.SetActive(true);

        Invoke("EnemyDie",0.2f);
    }
 }
 public void EnemyDie()
 {
  Destroy(gameObject);
 }

}
