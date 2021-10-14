using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    public static InputManager InputManagerInstanciado;
    PlayerInput PlayerInput;


    void Awake()
    {       
        if (InputManager.InputManagerInstanciado == null)
        {
           InputManager.InputManagerInstanciado = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    private void Start()
    {
       this.PlayerInput = GetComponent<PlayerInput>();
    }


    public void OnAtacar(InputValue Valor)
    {
        GameManager.gameManager.jugadorManager.jugadorController.atacar.Disparo();
        Debug.Log("Atacando");
    }


    public void OnMoverse(InputValue Valor)
    {
      Vector2 InputValor = Valor.Get<Vector2>();
      GameManager.gameManager.jugadorManager.jugadorController.movimiento.Direccion(InputValor.x);
    }
 

}