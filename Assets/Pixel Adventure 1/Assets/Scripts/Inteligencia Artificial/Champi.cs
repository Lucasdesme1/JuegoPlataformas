using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Champi : MonoBehaviour
{
  public Animator animator;
  public SpriteRenderer SpriteRenderer;
  public float SpeedEnemy = 5f;
  public float WaitTime;
  
  public float StartWaitTime = 2;

  public Transform[] moveSpots;
  private int i = 0;
  private Vector2 actualPos;

    void Start()
    {
     WaitTime = StartWaitTime;
     
    }

   
    void Update()
    {
     transform.position = Vector2.MoveTowards(transform.position,moveSpots[i].transform.position, SpeedEnemy * Time.deltaTime);

     if(Vector2.Distance(transform.position,moveSpots[i].transform.position)<0.1f)
     {
      if(WaitTime<=0)
      {
          if(moveSpots[i]!=moveSpots[moveSpots.Length-1])
          {
              i++;
          }
          else
          {
              i = 0;
          }

          WaitTime = StartWaitTime;
      }
      WaitTime -= Time.deltaTime;
     }


    }

    IEnumerator EnemyMoving()
    {
        actualPos=transform.position;

        yield return new WaitForSeconds(0.5f);

        if(transform.position.x>actualPos.x)
        {
            SpriteRenderer.flipX = true;
        }
        else if(transform.position.x < actualPos.x)
        {
            SpriteRenderer.flipX = false;
        }
    }
}
