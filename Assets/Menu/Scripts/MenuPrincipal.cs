using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }


    public void EmpezarJuego()
    {
        SceneManager.LoadScene("Game");
    }

    public void Opciones()
    {
        SceneManager.LoadScene("Opciones");
    }


    public void Salir()
    {
        Application.Quit();
    }

    public void Atras()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

}