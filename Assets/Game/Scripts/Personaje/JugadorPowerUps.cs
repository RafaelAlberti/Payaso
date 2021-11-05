using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorPowerUps : MonoBehaviour
{
    [SerializeField] JugadorController jugadorController;

    public bool pw = false;
    void Start()
    {
        this.jugadorController = GetComponent<JugadorController>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rojo"))
        {
            GloboRojo();
            GameManager.gameManager.jugadorManager.jugadorController.sonidos.SonidoGlobo();
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Verde"))
        {
            GameManager.gameManager.jugadorManager.jugadorController.sonidos.SonidoGlobo();
            GloboVerde();
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Azul"))
        {
            GloboAzul();
            GameManager.gameManager.jugadorManager.jugadorController.sonidos.SonidoGlobo();
            Destroy(collision.gameObject);
        }

    }


    public void GloboRojo()
    {
      jugadorController.RecibirVida();
       
    }


    public void GloboAzul()
    {
        pw = true;
    }


    public void GloboVerde()
    {
        jugadorController.RecibirDanio();
    }


}
