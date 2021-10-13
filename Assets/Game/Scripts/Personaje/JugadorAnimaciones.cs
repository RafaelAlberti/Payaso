using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorAnimaciones : MonoBehaviour
{
    [SerializeField] JugadorController jugadorController;
    private Animator Animator;

    void Start()
    {
        jugadorController = GetComponent<JugadorController>();
        Animator = GetComponent<Animator>();
    }

    
    void FixedUpdate()
    {
        Animacion();
    }

    
    public void Animacion()
    {   
       //Animator.SetBool("Muerte", Muerte.MuertePersonaje);
       //Animator.SetFloat("Velocidad", Mathf.Abs(mov.Direccion.x));
       //Animator.SetBool("Suelo", mov.Suelo());
       //Animator.SetBool("Disparar", Disparar.DisparoEstado);
    }



}
