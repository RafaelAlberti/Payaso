using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float saltar = 3;
    public float velocidad = 2;
    Rigidbody2D body;
    private Animator Animator;
    

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
       
    }

    private void Update()
    {
        Morir();
        Animacion();



    }

    void FixedUpdate()
    {
        Moverse();

        Saltar();
    } 
    

    public void Moverse()
    {

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            body.velocity = new Vector2(velocidad, body.velocity.y);

            if (body.velocity.x > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);  
            }
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            
            body.velocity = new Vector2(-velocidad, body.velocity.y);

            if (body.velocity.x < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

        }

        else
        {
            body.velocity = new Vector2(0, body.velocity.y);
        }

    }
    
    public void Saltar()
    {

        if (Input.GetKey("space") && ComprobarSuelo.Suelo)
        {
            body.velocity = new Vector2(body.velocity.x, saltar);
        }


    }

    public void Morir()
    {
        if (Muerte.MuertePersonaje == true)
        {
            Animator.SetBool("Muerte", Muerte.MuertePersonaje);
        }


    }

    public void Animacion()
    {
        Animator.SetFloat("Velocidad", Mathf.Abs(body.velocity.x));
        Animator.SetBool("Suelo", ComprobarSuelo.Suelo);
    }
}
