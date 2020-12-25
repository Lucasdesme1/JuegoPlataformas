using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
 public Animator Animator;
 public BoxCollider2D BoxCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
     if(collision.gameObject.CompareTag("Player"))
     {
      Animator.SetBool("Activated",true);
     }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
     Animator.SetBool("Activated",false);
    }
    
}
