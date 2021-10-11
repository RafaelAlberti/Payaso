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
        
        Instantiate(bala, PuntodeDisparo.position, PuntodeDisparo.rotation);
    }

  }
