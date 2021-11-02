using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    [SerializeField] UIcontroller UIcontroller;
    [SerializeField] private GameObject MenuPausa;
    [SerializeField] private GameObject Hud;
    [SerializeField] private string NombreNivel;


    private void Start()
    {
    }


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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameManager.gameManager.Nivel();
    }

    public void Opciones()
    {
        Time.timeScale = 1f;
        Hud.SetActive(false);
        SceneManager.LoadScene("Opciones", LoadSceneMode.Additive);
        GameManager.gameManager.Nivel();
        GameManager.gameManager.UIManager.menuManager.DestruirMenu();

    }

    public void Salir()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }

}
