using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEstado : MonoBehaviour
{

    [SerializeField] EnemigoController enemigoController;
    enum Comportamiento { corriendo, atacando }
    Comportamiento Estado = Comportamiento.corriendo;

    float DistanciaSegura = 11f;
    float DistanciaAtaque = 7f;
    float DistanciaDelPayaso;
    public Transform Payaso;

    private void Start()
    {
        this.enemigoController = GetComponent<EnemigoController>();
    }



    private void Update()
    {
        DistanciaDelPayaso = Mathf.Abs(Payaso.position.x - transform.position.x);
         switch (Estado)
         {
            case Comportamiento.corriendo:

                GameManager.gameManager.enemigoManager.enemigoController.movimiento.Caminar();
                
                if (DistanciaDelPayaso > DistanciaSegura)
                {
                    Estado = Comportamiento.atacando;
                    GameManager.gameManager.enemigoManager.enemigoController.disparo.EstadoAtaque = true;
                }

                break;

            case Comportamiento.atacando:

                if(DistanciaDelPayaso < DistanciaAtaque)
                {
                    Estado = Comportamiento.corriendo;
                    GameManager.gameManager.enemigoManager.enemigoController.disparo.EstadoAtaque = false;
                }

                
                GameManager.gameManager.enemigoManager.enemigoController.disparo.Disparo();

                break;
         }
    }


}
