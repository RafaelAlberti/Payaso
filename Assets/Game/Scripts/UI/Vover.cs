using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vover : MonoBehaviour
{

    [SerializeField] string NombreNivel;
    public void VolverAlJuego()
    {
        SceneManager.LoadScene(NombreNivel);
        Time.timeScale = 1;
        Muerte.MuertePersonaje = false;
    }

    public void VolverAlInicio()
    {
        SceneManager.LoadScene("MenuPrincipal");
        Time.timeScale = 1;
        Muerte.MuertePersonaje = false;
    }


}
