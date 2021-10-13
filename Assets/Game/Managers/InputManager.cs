using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Input;
    [SerializeField] private PlayerInput PlayerInput;


    public void Awake()
    {       
        if (InputManager.Input == null)
        {
           InputManager.Input = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    private void Start()
    {
        PlayerInput = GetComponent<PlayerInput>();
    }


    void OnAtacar(InputValue Valor)
    {
        
    }


    void OnMovimiento(InputValue Valor)
    {
      GameManager.gameManager.jugadorManager.jugadorController.movimiento.Moverse();
    }
 

}