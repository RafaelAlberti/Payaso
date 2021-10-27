using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorAtacar : MonoBehaviour
{

    [SerializeField] public JugadorController jugadorController;
    [SerializeField] private GameObject bala;
    [SerializeField] Transform PuntodeDisparo;
    [NonSerialized]public bool Disparar = false;
    private bool PresionandoDisparar = false;


    void Start()
    {
        jugadorController = GetComponent<JugadorController>();
    }

    public void Disparo(bool var)
    {
        Disparar = true;
        PresionandoDisparar = var;

        if (EstadoDisparo() == true && PresionandoDisparar == true && Disparar == true)
        {
            Instantiate(bala, PuntodeDisparo.position, PuntodeDisparo.rotation);
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


  
    void Controlador()
    {
        Disparar = false;
    }

}
