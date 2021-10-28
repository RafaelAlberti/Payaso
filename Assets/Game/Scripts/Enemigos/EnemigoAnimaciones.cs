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
        this.animator.SetBool("Quieto", GameManager.gameManager.enemigoManager.enemigoController.movimiento.Quieto);
        this.animator.SetFloat("Velocidad", Mathf.Abs(GameManager.gameManager.enemigoManager.enemigoController.movimiento.Correr));
        this.animator.SetBool("Disparar", GameManager.gameManager.enemigoManager.enemigoController.disparo.EstadoAtaque);
    }

}
