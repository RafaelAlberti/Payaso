using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorAnimaciones : MonoBehaviour
{
    Movimiento mov;
    private Animator Animator;

    void Start()
    {
        mov = GetComponent<Movimiento>();
        Animator = GetComponent<Animator>();
    }

    
    void FixedUpdate()
    {
        Animacion();
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
        Animator.SetFloat("Velocidad", Mathf.Abs(mov.Direccion.x));
        Animator.SetBool("Suelo", mov.Suelo());
        Animator.SetBool("Disparar", Disparar.DisparoEstado);
    }



}
