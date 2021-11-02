using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAnimaciones : MonoBehaviour
{
    [SerializeField] EnemigoController enemigoController;
    private Animator animator;
    void Start()
    {
        this.enemigoController = GetComponent<EnemigoController>();
        this.animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        Animaciones();
    }

    public void Animaciones()
    {
      this.animator.SetFloat("Velocidad", Mathf.Abs(enemigoController.movimiento.moverse));
      this.animator.SetBool("Disparar", enemigoController.disparo.EstadoAtaque);
    }

}
