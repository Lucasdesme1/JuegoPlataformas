using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public bool enableSelectCharacter;
   public enum Player{Frog, Virtualguy, Pinkman}
   public Player PlayerSelected;
   public Animator Anim;
   public SpriteRenderer SpriteRenderer;

   public RuntimeAnimatorController[] PlayerController;
   public Sprite[] PlayerRenderer;


    void Start()
    { 
        if(!enableSelectCharacter)
        {
         ChangePlayerInMenu();
        }

        else
        {
          switch (PlayerSelected)
      {
         case Player.Frog:
         SpriteRenderer.sprite = PlayerRenderer[0];
         Anim.runtimeAnimatorController = PlayerController[0];
        break;
        case Player.Virtualguy:
        SpriteRenderer.sprite = PlayerRenderer[1];
         Anim.runtimeAnimatorController = PlayerController[1];
        break;
        case Player.Pinkman:
         SpriteRenderer.sprite = PlayerRenderer[2];
          Anim.runtimeAnimatorController = PlayerController[2];
        break;
         default:
         break;
      }  
        }
    
     }


       public void ChangePlayerInMenu()
       {
            switch (PlayerPrefs.GetString("PlayerSelected"))
      {
         case "Frog":
         SpriteRenderer.sprite = PlayerRenderer[0];
         Anim.runtimeAnimatorController = PlayerController[0];
        break;
        case "Pinkman":
        SpriteRenderer.sprite = PlayerRenderer[1];
         Anim.runtimeAnimatorController = PlayerController[1];
        break;
        case"VirtualGuy":
         SpriteRenderer.sprite = PlayerRenderer[2];
          Anim.runtimeAnimatorController = PlayerController[2];
        break;
         default:
         break;
      }  
       } 
}
