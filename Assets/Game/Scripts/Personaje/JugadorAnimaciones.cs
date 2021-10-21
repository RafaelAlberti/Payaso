using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorAnimaciones : MonoBehaviour
{
    [SerializeField] JugadorController jugadorController;
    private Animator Animator;
   
  
 
    void Start()
    {
        this.jugadorController = GetComponent<JugadorController>();
        this.Animator = GetComponent<Animator>();
    }

    
    void FixedUpdate()
    {
        Animacion();
    }

    
    public void Animacion()
    {   
       Animator.SetBool("Muerte", Muerte.MuertePersonaje);
       Animator.SetFloat("Velocidad",Mathf.Abs(GameManager.gameManager.jugadorManager.jugadorController.movimiento.MovimientoHorizontal));
       Animator.SetBool("Suelo", GameManager.gameManager.jugadorManager.jugadorController.movimiento.Suelo());
       //Animator.SetTrigger(InputManager.InputManagerInstanciado.Atacar);
        // Animator.SetBool("Disparar", GameManager.gameManager.jugadorManager.jugadorController.atacar.EstadoDisparo);

    }
    
}
