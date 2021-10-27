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

    
     void Update()
    {
        Animacion();
    }

    
    public void Animacion()
    {   
       Animator.SetBool("Muerte", GameManager.gameManager.jugadorManager.jugadorController.morir.MuertePersonaje);
       Animator.SetFloat("Velocidad",Mathf.Abs(GameManager.gameManager.jugadorManager.jugadorController.movimiento.MovimientoHorizontal));
       Animator.SetBool("Suelo", GameManager.gameManager.jugadorManager.jugadorController.movimiento.Suelo());
       Animator.SetBool("Disparar", GameManager.gameManager.jugadorManager.jugadorController.atacar.Disparar);
       
    }
    

}
