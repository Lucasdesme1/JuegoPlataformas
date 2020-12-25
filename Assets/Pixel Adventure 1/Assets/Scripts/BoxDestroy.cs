using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    public BoxCollider2D BoxCollider2d;
    public Animator Anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter2D(Collider2D BoxCollider2d) 
    {
      if (BoxCollider2d.CompareTag("Player"))
      {
          
          Destroy(gameObject, 0.3f);}
          
}
}
