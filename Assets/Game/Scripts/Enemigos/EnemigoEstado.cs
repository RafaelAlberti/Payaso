using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEstado : MonoBehaviour
{

    [SerializeField] EnemigoController enemigoController;
    [SerializeField] Transform Payaso;
    enum Comportamiento { corriendo, atacando }
    Comportamiento Estado = Comportamiento.corriendo;

    [SerializeField] float DistanciaSeguraSalida = 8f;
    [SerializeField] float DistanciaAtaque = 6f;

    float DistanciaDelPayaso;


    private void Start()
    {
        this.enemigoController = GetComponent<EnemigoController>();
    }



    private void Update()
    {
        Transform transform1 = GameObject.Find("Payaso(Clone)").GetComponent<JugadorController>().transform;
        Payaso = transform1;
        DistanciaDelPayaso = Mathf.Abs(Payaso.position.x - this.transform.position.x);
        EstadosComportamiento();
    }


    void EstadosComportamiento()
    {
        switch (Estado)
        {
            case Comportamiento.corriendo:

                enemigoController.movimiento.Moverse();
                enemigoController.disparo.EstadoAtaque = false;

                if (DistanciaDelPayaso < DistanciaAtaque)
                {
                    Estado = Comportamiento.atacando;
                    enemigoController.movimiento.Quieto();
                    GirarDireccionJugador();
                }

                break;

            case Comportamiento.atacando:

                if (DistanciaDelPayaso > DistanciaSeguraSalida)
                {
                    Estado = Comportamiento.corriendo;
                }

                enemigoController.disparo.EstadoAtaque = true;
                enemigoController.disparo.Disparo();
                GirarDireccionJugador();
                break;
        }




    }


    void GirarDireccionJugador()
    {
        if (Payaso.position.x > transform.position.x)
        {
          enemigoController.movimiento.Direccion = -1;
        }
        if (Payaso.position.x < transform.position.x)
        { 
          enemigoController.movimiento.Direccion = 11; 
        }

    }
}
