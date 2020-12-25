using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenDoor : MonoBehaviour
{
    private bool indoor = false;
    public string levelName;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("Player"))
        {
        indoor = true;
        Debug.Log("PUERTA");
        SceneManager.LoadScene(levelName);
        }
    }
    private void OnTriggerexit2D(Collider2D collision) 
    {
     indoor = false;
    }

    private void update()
    {
      
    }
}
