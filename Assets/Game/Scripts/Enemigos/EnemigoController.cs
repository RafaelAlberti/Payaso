using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoController : MonoBehaviour
{
    [SerializeField] EnemigoAnimaciones animaciones;
    [SerializeField] EnemigoDisparo disparo;
    [SerializeField] EnemigoMovimiento movimiento;
    [SerializeField] EnemigoSonidos sonidos;

    void Start()
    {
        this.animaciones = GetComponent<EnemigoAnimaciones>();
        this.disparo = GetComponent<EnemigoDisparo>();
        this.movimiento = GetComponent<EnemigoMovimiento>();
        this.sonidos = GetComponent<EnemigoSonidos>();
    }

    
    void Update()
    {
        
    }
}
