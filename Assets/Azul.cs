using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul : MonoBehaviour
{
    public BoxCollider2D Coll;
    public bool blue;
    private Movimiento movimiento;
    void Start()
    {
        movimiento = FindObjectOfType<Movimiento>();
        
    }

    // Update is called once per frame
    void Update()
    {
        blue = movimiento.Blue;
        if (blue == false) 
        {
            Coll.enabled = false;
        }
        if (blue == true)
        {
            Coll.enabled = true;
        }
    
    }
}
