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
       Animator.SetBool("Disparar", FuncionDisparo());
    }
    

    bool FuncionDisparo()
    {
        if (GameManager.gameManager.jugadorManager.jugadorController.atacar.ControlarSuelo() == true && 
            GameManager.gameManager.jugadorManager.jugadorController.atacar.ControlarVelocidad() < 0.1)
        {
            bool Disparo = true;  
            return Disparo;        
        }
        else
        {
            bool Disparo = false;
            return Disparo;
        }
    }

}
