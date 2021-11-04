using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    public static InputManager InputManagerInstanciado;
    PlayerInput PlayerInput;
    [NonSerialized]public bool Presionar;

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

    public void OnDestroy()
    {
        Destroy(this.gameObject);
    }

    private void Start()
    {
       this.PlayerInput = GetComponent<PlayerInput>();
    }

    public void OnAtacar(InputValue Valor)
    {
        Presionar = Valor.isPressed;
        GameManager.gameManager.jugadorManager.jugadorController.atacar.Disparo(Presionar);
    }


    public void OnMoverse(InputValue Valor)
    {
      Vector2 InputValor = Valor.Get<Vector2>();
      GameManager.gameManager.jugadorManager.jugadorController.movimiento.Moverse(InputValor.x);
    }

    public void OnSaltar(InputValue Valor)
    {
       GameManager.gameManager.jugadorManager.jugadorController.movimiento.Saltar();
    }

    public void OnPausa(InputValue Valor)
    {
        GameManager.gameManager.UIManager.UIcontroller.MenuPausa.Pausar();
    }


}