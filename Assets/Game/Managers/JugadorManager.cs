using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class JugadorManager : MonoBehaviour
{
    [SerializeField] private GameObject Jugador;
    [SerializeField] private Transform spawn;
    public JugadorController jugadorController;
    GameObject InstanciaJugador;
    public void SpawnDePersonaje()
    {

        //this.jugadorController = null;

        CinemachineVirtualCamera Camara = GameObject.Find("CamaraCinematica").GetComponent<CinemachineVirtualCamera>();

        this.InstanciaJugador = Instantiate(Jugador, spawn.transform.position, Quaternion.identity);

        this.InstanciaJugador.transform.parent = GameObject.Find("Jugador").transform;

        this.jugadorController = GetComponent<JugadorController>();

        Camara.m_Follow = InstanciaJugador.transform;
    }

}
