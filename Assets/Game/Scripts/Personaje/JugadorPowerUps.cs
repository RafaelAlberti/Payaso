using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorPowerUps : MonoBehaviour
{
    [SerializeField] JugadorController jugadorController;
    void Start()
    {
        this.jugadorController = GetComponent<JugadorController>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rojo"))
        {
            GloboRojo();
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Verde"))
        {
            GloboVerde();
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Azul"))
        {
            GloboAzul();
            Destroy(collision.gameObject);
        }

    }


    public void GloboRojo()
    {
      jugadorController.RecibirVida();
    }


    public void GloboAzul()
    {
        Debug.Log("Hola, Yo soy el globo azul con el nuevo sistema");
    }


    public void GloboVerde()
    {
        jugadorController.RecibirDanio();
    }


}
