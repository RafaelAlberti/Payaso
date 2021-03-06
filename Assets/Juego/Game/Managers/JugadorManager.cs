using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Cinemachine;


public class JugadorManager : MonoBehaviour
{   
    public JugadorController jugadorController;
    [SerializeField] public GameObject Jugador;
    [SerializeField] public Transform spawn;
    [NonSerialized]  public GameObject InstanciaJugador;


    public void SpawnDePersonaje()
    {

        CinemachineVirtualCamera Camara = GameObject.Find("CamaraCinematica").GetComponent<CinemachineVirtualCamera>();

        InstanciaJugador = Instantiate(Jugador, spawn.position, Quaternion.identity);

        InstanciaJugador.transform.parent = GameObject.Find("Jugador").transform;

        jugadorController = InstanciaJugador.GetComponent<JugadorController>();

        Camara.m_Follow = InstanciaJugador.transform;

    }
}
