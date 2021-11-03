using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMuere : MonoBehaviour
{
    [SerializeField] JugadorController jugadorController;
    int Vida;
    void Start()
    {
        this.jugadorController = GetComponent<JugadorController>();
        Vida = GameManager.gameManager.UIManager.UIcontroller.hud.VidaMaxima;
    }

    private void Update()
    {
        muerte();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Muerte"))
        {
            jugadorController.RecibirDanio();
        }
        if (collision.CompareTag("Enemigo"))
        {
            jugadorController.RecibirDanio();
        }

    }

    void muerte()
    {
        if(Vida <= 0)
        {
            GameManager.gameManager.UIManager.UIcontroller.hud.muerte();
            Time.timeScale = 0;
        }
    }


}
