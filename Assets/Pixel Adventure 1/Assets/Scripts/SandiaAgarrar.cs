using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Try to write the OntriggerEnter2D
//Wait i think i solve it, the item should have a RigidBody2D and now the OntriggerEnter2D does not give a error,Nothing
public class SandiaAgarrar : MonoBehaviour
{
   
    void Start() 
    {
        
    }

    void Update() 
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
      if (collision.CompareTag("Player"))
      {
          GetComponent<SpriteRenderer>().enabled = false;
          gameObject.transform.GetChild(0).gameObject.SetActive(true);
          Destroy(gameObject, 0.5f);
           
      }
    }
    
}