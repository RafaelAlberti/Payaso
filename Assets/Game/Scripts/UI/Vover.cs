using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vover : MonoBehaviour
{ 
    
    
    public void VolverAlJuego()
    {
        SceneManager.LoadScene("Game");
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
