using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorController : MonoBehaviour
{
    public JugadorAnimaciones animaciones;
    public JugadorAtacar atacar;
    public JugadorMovimiento movimiento;
    public JugadorPowerUps powerUps;

    void Start()
    {
       this.animaciones = GetComponent<JugadorAnimaciones>();
       this.atacar = GetComponent<JugadorAtacar>();
       this.movimiento = GetComponent<JugadorMovimiento>();
       this.powerUps = GetComponent<JugadorPowerUps>();
    }
}
