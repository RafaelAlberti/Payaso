using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ControladorCinematica : MonoBehaviour
{
    public static ControladorCinematica controlador;
    public PlayableDirector Director;



    private void Update()
    {
        if(GameManager.gameManager.jugadorManager.jugadorController.cinematica == true)
        {
            SegundaCinematicas();
            GameManager.gameManager.jugadorManager.jugadorController.cinematica = false;
        }
    }


    public void SegundaCinematicas()
     {
        Director.Play();
     }
   


}
