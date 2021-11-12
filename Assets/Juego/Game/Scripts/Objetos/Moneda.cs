using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.gameManager.jugadorManager.jugadorController.sonidos.SonidoMoneda();
            gameManager.SumarMonedas();
            Destroy(this.gameObject);
        }
    }
}
