using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
  private PlatformEffector2D effector;
  public float StarwaitTime;
  private float WaitedTime; 


    void Start()
    {
    effector = GetComponent<PlatformEffector2D>();
    }

   
    void Update()
    {
          if(Input.GetKeyUp(KeyCode.S))
          {
           WaitedTime = StarwaitTime;
          }

        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
         if(WaitedTime<=0)
         {
          effector.rotationalOffset=180f;
          WaitedTime = StarwaitTime;
         }
         
         
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            effector.rotationalOffset = 0;
        }
    }
}
