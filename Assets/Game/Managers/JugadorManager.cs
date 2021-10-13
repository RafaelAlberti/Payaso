using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorManager : MonoBehaviour
{
    [SerializeField] private GameObject Jugador;
    [SerializeField] private Transform spawn;
    public JugadorController jugadorController;
   

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    private void SpawnDePersonaje()
    {
        GameObject InstanciaJugador = Instantiate(Jugador, spawn.transform.position, Quaternion.identity);
        InstanciaJugador.transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
        jugadorController = GetComponent<JugadorController>();
    }

}
