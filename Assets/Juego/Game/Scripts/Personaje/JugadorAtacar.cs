using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorAtacar : MonoBehaviour
{

    [SerializeField] public JugadorController jugadorController;
    [SerializeField] public GameObject bala;
    [SerializeField] Transform PuntodeDisparo;
    [NonSerialized]public bool Disparar = false;
    private bool PresionandoDisparar = false;


    void Start()
    {
        jugadorController = GetComponent<JugadorController>();
    }

    public void Disparo()
    {
        Disparar = true;
        
        if (EstadoDisparo() == true && PresionandoDisparar == true && Disparar == true)
        {
            Instantiate(bala, PuntodeDisparo.position, PuntodeDisparo.rotation);
            GameManager.gameManager.jugadorManager.jugadorController.sonidos.SonidoDisparo();
            Invoke("Controlador", 0.25f);
        }
        
    }

    public bool EstadoDisparo()
    {

        bool Suelo = GameManager.gameManager.jugadorManager.jugadorController.movimiento.Suelo();
        float Quieto = Mathf.Abs(GameManager.gameManager.jugadorManager.jugadorController.movimiento.MovimientoHorizontal);

        if (Suelo == true && Quieto < 0.1)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public void InputDisparo(bool var)
    {
        PresionandoDisparar = var;
    }
  
    void Controlador()
    {
        Disparar = false;
    }

}
