using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristalAzul : MonoBehaviour
{
    private Movimiento movimiento;
    void Start()
    {
        movimiento = FindObjectOfType<Movimiento>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (movimiento.Blue == false)
            {
                Destroy(gameObject);
            }
        }
    }
}
