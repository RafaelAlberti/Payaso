using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject Jugador;
   
    void Start()
    {
        Jugador = GetComponent<GameObject>();
    }

    
    void Update()
    {
        
    }

    private void InstanciarJugador()
    {

    }


}
