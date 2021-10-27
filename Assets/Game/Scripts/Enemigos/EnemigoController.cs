using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoController : MonoBehaviour
{
    [SerializeField] EnemigoAnimaciones animaciones;
    [SerializeField] EnemigoDisparo disparo;
    [SerializeField] EnemigoMovimiento movimiento;
    [SerializeField] EnemigoMuere muere;
    [SerializeField] EnemigoSonidos sonidos;
    void Start()
    {
        this.animaciones = GetComponent<EnemigoAnimaciones>();
        this.disparo = GetComponent<EnemigoDisparo>();
        this.movimiento = GetComponent<EnemigoMovimiento>();
        this.muere = GetComponent<EnemigoMuere>();
        this.sonidos = GetComponent<EnemigoSonidos>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
