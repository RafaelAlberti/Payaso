using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorAtacar : MonoBehaviour
{
    [SerializeField] public JugadorController jugadorController;
    [SerializeField] private GameObject bala;
    [SerializeField] Transform PuntodeDisparo;
    public static bool DisparoEstado;

    void Start()
    {
        jugadorController = GetComponent<JugadorController>();
    }

        
    public bool VerificarEstado()
    {

        if (DisparoEstado == false)
        {
            DisparoEstado = true;
        }
        else
        {
            DisparoEstado = false;
        }

        return DisparoEstado;
    }


    public void Disparo()
    {
        if (DisparoEstado == false)
        {
            DisparoEstado = true;
            Instantiate(bala, PuntodeDisparo.position, PuntodeDisparo.rotation);
        }
    }




}
