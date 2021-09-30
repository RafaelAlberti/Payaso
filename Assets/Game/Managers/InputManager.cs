using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    Movimiento movimiento;
   
    
    void Start()
    {
        
        movimiento = GetComponent<Movimiento>();
        
    }

    void OnAtacar(InputValue Valor)
    {
        
    }

    void OnMovimiento(InputValue Valor)
    {
        
    }
 

}