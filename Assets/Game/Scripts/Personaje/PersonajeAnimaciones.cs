using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeAnimaciones : MonoBehaviour
{
    private Movimiento mov;
    private Animator Animator;
    void Start()
    {
        Animator = GetComponent<Animator>();
        mov = GetComponent<Movimiento>();
    }

    
    void Update()
    {
        
    }

    public void Animacion()
    {
        Animator.SetFloat("Velocidad", Mathf.Abs(mov.Direccion.x));
        Animator.SetBool("Suelo", ComprobarSuelo.Suelo);
        Animator.SetBool("Disparar", Disparar.Disparo);
    }

    
}
