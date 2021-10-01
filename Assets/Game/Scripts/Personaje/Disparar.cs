using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Disparar : MonoBehaviour
{

    PlayerInput Input;
    [SerializeField] Transform PuntodeDisparo;
    [SerializeField] private GameObject bala;
    float disparo;
    public static bool DisparoEstado;

    void Start()
    {
        Input = GetComponent<PlayerInput>();
    }

    
    void Update()
    {
        
    }

   
    public void OnAtacar(InputValue valor)
    {
        DisparoEstado = false;
        disparo = valor.Get<float>();
        
        Instantiate(bala, PuntodeDisparo.position, PuntodeDisparo.rotation);
        Estado();
    }

    bool Estado()
    {
        if (disparo >= 0) {
            return DisparoEstado = true;
        } else
        {
            return DisparoEstado = false;
        }

    } 
}
