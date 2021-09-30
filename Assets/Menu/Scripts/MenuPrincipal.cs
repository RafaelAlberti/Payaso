using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{


    public void EmpezarJuego()
    {
        SceneManager.LoadScene("Nivel-1", LoadSceneMode.Single);
    }

    public void Opciones()
    {
        SceneManager.LoadScene("Opciones", LoadSceneMode.Additive);
    }


    public void Salir()
    {
        Application.Quit();
    }

    public void Atras()
    {
        SceneManager.LoadScene("MenuPrincipal" , LoadSceneMode.Single);
    }

}