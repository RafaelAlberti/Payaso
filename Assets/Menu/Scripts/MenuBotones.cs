using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBotones : MonoBehaviour
{
    [SerializeField] MenuController menuController;
    void Start()
    {
        menuController = GetComponent<MenuController>();
    }

   

    public void Jugar()
    {
       MenuManager.menuManagerInstancia.DestruirMenu();
       SceneManager.LoadScene("Nivel-1", LoadSceneMode.Single);
    }

    public void Opciones()
    {
        SceneManager.LoadScene("Opciones", LoadSceneMode.Additive);
    }

    

    public void Volver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
