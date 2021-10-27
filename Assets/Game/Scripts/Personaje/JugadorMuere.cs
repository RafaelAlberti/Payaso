using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMuere : MonoBehaviour
{
    [SerializeField] JugadorController jugadorController;
    [SerializeField] private GameObject Perdiste;
    public bool MuertePersonaje;
    void Start()
    {
        this.jugadorController = GetComponent<JugadorController>();
        this.Perdiste = GameObject.Find("Perdiste");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Muerte") && MuertePersonaje == false)
        {
            QuitarVida();
        }
    }

    private void QuitarVida()
    {
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        GameManager.gameManager.jugadorManager.SpawnDePersonaje();
    }



}