using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEstado : MonoBehaviour
{

    [SerializeField] EnemigoController enemigoController;
    enum Comportamiento {corriendo, atacando}
    float DistanciaSegura = 11f;
    float DistanciaAtaque = 7f;
    float DistanciaDelPayaso;
    public Transform Payaso;

    private void Start()
    {
        this.enemigoController = GetComponent<EnemigoController>();
    }


    
}
