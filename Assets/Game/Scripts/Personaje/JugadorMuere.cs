using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMuere : MonoBehaviour
{
    [SerializeField] JugadorController jugadorController;
    [SerializeField] private GameObject Perdiste;
    public bool MuertePersonaje;
    int VidaMaxima = 3;
    int VidaActual;
    void Start()
    {
        this.jugadorController = GetComponent<JugadorController>();
        this.Perdiste = GameObject.Find("Perdiste");
        VidaActual = VidaMaxima;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Estrella"))
        {
            QuitarVida();
        }

    }

    public void QuitarVida()
    {
        //Destroy(GameManager.gameManager.jugadorManager.InstanciaJugador);
        //ameManager.gameManager.jugadorManager.SpawnDePersonaje();
        VidaActual -= 1;
        Debug.Log(VidaActual);
        if (VidaActual <= 0)
        {
            Debug.Log("Me mataste Rancio");
        }
    }

    void MuerteFinal()
    {
        //bool MuertePersonaje = true;
        Time.timeScale = 0;
        Perdiste.SetActive(true);
    }

}
