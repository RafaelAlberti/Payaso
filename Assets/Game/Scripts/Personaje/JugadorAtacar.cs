using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorAtacar : MonoBehaviour
{


    [SerializeField] public JugadorController jugadorController;
    [SerializeField] private GameObject bala;
    [SerializeField] Transform PuntodeDisparo;
    public string EstadoDisparo;


    void Start()
    {
       jugadorController = GetComponent<JugadorController>();
    }

 
    public void Disparo()
    {
        if (ControlarSuelo() == true && ControlarVelocidad() < 0.1 )
        {
          Instantiate(bala, PuntodeDisparo.position, PuntodeDisparo.rotation);
        }
    }


   public bool ControlarSuelo( )
   { 
        bool Quieto = GameManager.gameManager.jugadorManager.jugadorController.movimiento.Suelo();
        return Quieto; 
   }
   

   public float ControlarVelocidad()
   {
       float Velocidad = Mathf.Abs(GameManager.gameManager.jugadorManager.jugadorController.movimiento.MovimientoHorizontal);
       return Velocidad;
   }


}
