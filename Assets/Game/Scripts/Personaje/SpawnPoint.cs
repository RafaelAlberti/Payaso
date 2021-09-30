using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    
    [SerializeField] private GameObject Jugador;
    [SerializeField] private Transform PosicionSpawn;
    

    void Start()
    {

    }

    
    void Update()
    {
        DestruirJugador();
        InstanciarJugador();
    }


    private void DestruirJugador()
    {
        if (Muerte.MuertePersonaje == true)
        {
            Destroy(Jugador, 1f);
        }
    }

    private void InstanciarJugador()
    {
        if ( Muerte.MuertePersonaje == true)
        {
          GameObject NewJugador = Instantiate(Jugador, PosicionSpawn.position, Quaternion.identity);
        }
       
    }


}
