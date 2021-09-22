using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movimiento : MonoBehaviour
{
    PlayerInput playerInput;
    Transform Jugador;
    public float saltar = 5.0f;
    public float velocidad = 5.0f;
    private Animator Animator;
    //float DireccionInput;
    private Vector2 Direccion;


    void Start()
    {
        Jugador = GetComponent<Transform>();
        playerInput = GetComponent<PlayerInput>();
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

    public void OnMoverse(InputValue valor)
    {
        this.Direccion = valor.Get<Vector2>();
        
    }

    public void Moverse()
    {
        Jugador.Translate(Vector3.right * Direccion * Time.deltaTime * this.velocidad);
        
        if (Direccion.x >= 0)
        {
            Jugador.localScale = new Vector3(1, 1, 1);

        }
        else
        {
            Jugador.localScale = new Vector3(-1, 1, 1);
        }
    }

   /** public void EntradaInput(float Direccion)
    {
        this.DireccionInput = Direccion;
    }**/

   public void Saltar()
    { 
       Jugador.Translate(Vector3.up * this.Direccion.y * Time.deltaTime * this.saltar);
    }

    public void Morir()
    {
        if (Muerte.MuertePersonaje == true)
        {
            Animator.SetBool("Muerte", Muerte.MuertePersonaje);
        }


    }

    public void Atacar()
    {

    }


    public void Animacion()
    {
        Animator.SetFloat("Velocidad", Mathf.Abs(Direccion.x));
        Animator.SetBool("Suelo", ComprobarSuelo.Suelo);
    }
}
