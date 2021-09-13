using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public Movimiento Movimiento;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }


   void OnAtacar() 
    {
       Movimiento.Moverse();
    }

    void OnSaltar()
    {
        Movimiento.Saltar();
    }

}
