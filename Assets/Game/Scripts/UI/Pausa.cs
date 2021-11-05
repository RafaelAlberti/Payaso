using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    [SerializeField] UIcontroller UIcontroller;
    [SerializeField] private GameObject MenuPausa;
    [SerializeField] private GameObject Hud;



    public void Pausar()
    {
        Time.timeScale = 0f;
        MenuPausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        MenuPausa.SetActive(false);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        GameManager.gameManager.Nivel();
        InputManager.InputManagerInstanciado.OnDestroy();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Opciones()
    {
        Time.timeScale = 1f;
        Hud.SetActive(false);
        SceneManager.LoadScene("Opciones", LoadSceneMode.Additive);
        GameManager.gameManager.UIManager.menuManager.DestruirMenu();
    }

    public void Guardar()
    {
        GameManager.gameManager.GuardarPartida();
    }


    public void Cargar()
    {
        GameManager.gameManager.CargarPartida();
    }

    public void Salir()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }

}
