using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
public class Final : MonoBehaviour
{
    public static ControladorCinematica controlador;
    public PlayableDirector CinematicaFinal;
    void Start()
    {

    }

    void Update()
    {
        if (GameManager.gameManager.jugadorManager.jugadorController.cinematicaFinal == true)
        {
            EscenaFinal();
            GameManager.gameManager.jugadorManager.jugadorController.cinematicaFinal = false;
            Invoke("VolverAlMenu", 3f);
        }
    }

    public void EscenaFinal()
    {
        CinematicaFinal.Play();
    }

    void VolverAlMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }



}
