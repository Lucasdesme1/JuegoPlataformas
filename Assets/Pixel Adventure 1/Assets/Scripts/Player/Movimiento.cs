    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    public float vel = 5.0f;
    public float Fuerzasalto = 600f;
    public float doublejumpspeed = 500f;
    private bool canDoubleJump;
    public LayerMask capasuelo;
    public Transform CheckSuelo;
    bool ensuelo;
    Rigidbody2D rb;
    public SpriteRenderer spriter;
    public Animator animator;
    public bool Blue = false;
   
  


    private void Start()
    {
        Blue = false;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        GetComponent<PlayerRespawn>();
        GameObject.Find("FruitManager");

    }

    // Update is called once per frame
    private void Update()
    {
        float h = Input.GetAxis("Horizontal") * vel;

        rb.velocity = new Vector2(h, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.W) && ensuelo)
        {
            rb.AddForce(Vector2.up * Fuerzasalto);
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            spriter.flipX = false;
            animator.SetBool("Move", true);
        }
        else animator.SetBool("Move", false);
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            spriter.flipX = true;
            animator.SetBool("Move", true);
        }
        if (CheckSuelo == false)
        {
            animator.SetBool("jump", true);
        }
        

      
    }

    private void FixedUpdate()
    {
        ensuelo = Physics2D.OverlapCircle(CheckSuelo.position, 0.1f, capasuelo);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Blue Cristal"))
        {
            Debug.Log("Blue Cristal Take");
            Blue = true;
            animator.SetBool("Blue", true);

        }
        if (collision.CompareTag("NormalCristal"))
            {
            Blue = false;
            animator.SetBool("Blue", false);
            }
        if (collision.CompareTag("Damage") && Blue == false)
        {
            if (Blue == true)
            {
                animator.Play("BlueChristalHitPinkMan");
            }
            if (Blue == false)
            {
                animator.Play("Hit");
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        if (collision.transform.CompareTag("BlueDamage") && Blue == true)
        {
            if (Blue == true)
            {
                animator.Play("BlueChristalHitPinkMan");
            }
            if (Blue == false)
            {
                animator.Play("Hit");
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.CompareTag("Meta") && Blue == true)
        {
            Debug.Log("Victoria papa");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
   

}
