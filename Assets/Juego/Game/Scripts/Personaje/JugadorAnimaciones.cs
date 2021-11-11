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
       this.Animator.SetFloat("Velocidad",Mathf.Abs(GameManager.gameManager.jugadorManager.jugadorController.movimiento.MovimientoHorizontal));
       this.Animator.SetBool("Suelo", GameManager.gameManager.jugadorManager.jugadorController.movimiento.Suelo());
       this.Animator.SetBool("Disparar", GameManager.gameManager.jugadorManager.jugadorController.atacar.Disparar);
       
    }
    

}
