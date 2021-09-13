using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{ 
    [SerializeField] private Transform Jugador;
    public float saltar = 3.0f;
    public float velocidad = 0.04f;
    private Animator Animator;
    float HorizontalInput;
    float VerticalInput;




    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Morir();
        Animacion();
        Moverse();
       Saltar();
    }

    void FixedUpdate()
    {
        
    } 
    

    public void Moverse()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
      
       Jugador.Translate(Vector3.right * HorizontalInput * velocidad );
     
        Debug.Log(HorizontalInput);

    }



    public void Saltar()
    {
       
        VerticalInput = Input.GetAxis("Vertical");
       
        Jugador.Translate(Vector3.up * VerticalInput * saltar);

        Debug.Log(VerticalInput);
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
        //Animator.SetFloat("Velocidad", Mathf.Abs(body.velocity.x));
        //Animator.SetBool("Suelo", ComprobarSuelo.Suelo);
    }
}
