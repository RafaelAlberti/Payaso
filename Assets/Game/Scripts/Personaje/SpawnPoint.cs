using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    [SerializeField] private GameObject Jugador;
    [SerializeField] private Transform PosicionSpawn;


    private void Start()
    {
        InstanciarJugador();
    }
    public void InstanciarJugador()
    {
        GameObject NewJugador = Instantiate(Jugador, PosicionSpawn.position, Quaternion.identity);
    }


}
