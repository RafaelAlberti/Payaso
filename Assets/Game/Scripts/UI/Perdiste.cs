using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perdiste : MonoBehaviour
{
    public string nombreNivel;

    public void Reiniciar()
    {
        SceneManager.LoadScene(nombreNivel, LoadSceneMode.Single);
        GameManager.gameManager.Nivel();
        InputManager.InputManagerInstanciado.OnDestroy();
    }


    public void Salir()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }
}
