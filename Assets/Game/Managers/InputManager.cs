using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    Movimiento movimiento;
   
    PlayerInput playerInput;
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        movimiento = GetComponent<Movimiento>();
        
    }

    void OnAtacar(InputValue Valor)
    {
        
    }

    void OnMovimiento(InputValue Valor)
    {
        /**Vector2 Direccion = Valor.Get<Vector2>();
        movimiento.EntradaInput(Direccion.x);**/

    }
 

}