using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoController : MonoBehaviour
{
    public EnemigoAnimaciones animaciones;
    public EnemigoDisparo disparo;
    public EnemigoMovimiento movimiento;
    public EnemigoMuere muere;
    public EnemigoSonidos sonidos;
    void Start()
    {
        this.animaciones = GetComponent<EnemigoAnimaciones>();
        this.disparo = GetComponent<EnemigoDisparo>();
        this.movimiento = GetComponent<EnemigoMovimiento>();
        this.muere = GetComponent<EnemigoMuere>();
        this.sonidos = GetComponent<EnemigoSonidos>();
    }

    
    void Update()
    {
        
    }
}
