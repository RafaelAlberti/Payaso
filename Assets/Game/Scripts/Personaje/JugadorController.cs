using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorController : MonoBehaviour
{
    public JugadorAnimaciones animaciones;
    public JugadorAtacar atacar;
    public JugadorMovimiento movimiento;
    public JugadorPowerUps powerUps;
    public JugadorMuere morir;
    public bool cinematica = false;

    void Start()
    {

       this.animaciones = GetComponent<JugadorAnimaciones>();
       this.atacar = GetComponent<JugadorAtacar>();
       this.movimiento = GetComponent<JugadorMovimiento>();
       this.powerUps = GetComponent<JugadorPowerUps>();
       this.morir = GetComponent<JugadorMuere>();
    }


    public void RecibirDanio()
    {
        GameManager.gameManager.UIManager.UIcontroller.hud.HacerDanio();
        GameManager.gameManager.UIManager.UIcontroller.hud.QuitarVidas();
        Destroy(GameManager.gameManager.jugadorManager.InstanciaJugador);
        GameManager.gameManager.jugadorManager.SpawnDePersonaje();
    }

    public void RecibirVida()
    {
        GameManager.gameManager.UIManager.UIcontroller.hud.Curar();
        GameManager.gameManager.UIManager.UIcontroller.hud.AgregarVidas();
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("CinematicaSegunda"))
        {
            cinematica = true;
        }

    }

  

}
