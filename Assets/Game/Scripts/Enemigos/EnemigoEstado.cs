using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEstado : MonoBehaviour
{

    [SerializeField] EnemigoController enemigoController;
    enum Comportamiento { corriendo, atacando }
    Comportamiento Estado = Comportamiento.corriendo;

    float DistanciaSeguraSalida = 8f;
    float DistanciaAtaque = 6f;
    float DistanciaDelPayaso;
    public Transform Payaso;

    private void Start()
    {
        this.enemigoController = GetComponent<EnemigoController>();
    }



    private void Update()
    {
        Payaso = GameObject.Find("Payaso(Clone)").GetComponent<JugadorController>().transform;

        DistanciaDelPayaso = Mathf.Abs(Payaso.position.x - this.transform.position.x );
        Debug.Log(DistanciaDelPayaso);

        EstadosComportamiento();
    }


    void EstadosComportamiento() 
    {
        switch (Estado)
        {
            case Comportamiento.corriendo:

                GameManager.gameManager.enemigoManager.enemigoController.movimiento.Moverse();
                GameManager.gameManager.enemigoManager.enemigoController.disparo.EstadoAtaque = false;

                if (DistanciaDelPayaso < DistanciaAtaque)
                {
                    Estado = Comportamiento.atacando;
                }

                break;

            case Comportamiento.atacando:

                if (DistanciaDelPayaso > DistanciaSeguraSalida)
                {
                    Estado = Comportamiento.corriendo;
                }

                GirarDireccionJugador();
                GameManager.gameManager.enemigoManager.enemigoController.disparo.EstadoAtaque = true;
                GameManager.gameManager.enemigoManager.enemigoController.disparo.Disparo();

                break;
        }




    }


    void GirarDireccionJugador()
    {
        if (Payaso.position.x > transform.position.x)
        {
            GameManager.gameManager.enemigoManager.enemigoController.movimiento.Direccion = -1;
        }
        if (Payaso.position.x < transform.position.x)
        { 
            GameManager.gameManager.enemigoManager.enemigoController.movimiento.Direccion = 11; 
        }

    }
}
