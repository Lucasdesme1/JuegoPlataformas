using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkinDoor : MonoBehaviour
{

    public GameObject Skinspanel;
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("Player"))
        {
         Skinspanel.gameObject.SetActive(true);

        }
    }
    private void OnTriggerExit2D (Collider2D collision)
    {
        Skinspanel.gameObject.SetActive(false);
    }

    public void SetPlayerFrog()
    {
        PlayerPrefs.SetString("PlayerSelected","forg");
        ResetPlayerSkin();
    } 
    public void SetPlayerPinkMan()
    {
        PlayerPrefs.SetString("PlayerSelected","PinkMan");
        ResetPlayerSkin();
    }
     public void SetPlayerVirtualGuy()
    {
        PlayerPrefs.SetString("PlayerSelected","VirtualGuy");
        ResetPlayerSkin();
    }

    void ResetPlayerSkin()
    {
     Skinspanel.gameObject.SetActive(false);
     player.GetComponent<PlayerSelect>().ChangePlayerInMenu();  
    }
}