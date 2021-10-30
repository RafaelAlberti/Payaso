using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class JugadorManager : MonoBehaviour
{  
    [SerializeField] public GameObject Jugador;
    [SerializeField] public Transform spawn;
    public JugadorController jugadorController;
    [NonSerialized]  public GameObject InstanciaJugador;


   
}
