using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerRespawn : MonoBehaviour
{
   private float CheckPointPositionX,CheckPointPositionY;

   public Animator animator;
    public bool blue = false;
    void Update()
    {


    }

  public void PlayerDamage()
  {
        if (blue == true) 
        {
            animator.Play("BlueChristalHitPinkMan");
        }
        if (blue == false)
        {
            animator.Play("Hit");
        }
   SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
