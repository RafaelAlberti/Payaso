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
        morir.QuitarVida();
    }


}
