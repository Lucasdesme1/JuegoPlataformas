using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FruitManager : MonoBehaviour
{
    public GameObject transition;
    private void Update()
    {
        AllFruitCollected();
    }
 public void AllFruitCollected()
 {
     if(transform.childCount==0)
     {
         Debug.Log("Victoria papa");
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
         transition.SetActive(true);
     }
 }

}
