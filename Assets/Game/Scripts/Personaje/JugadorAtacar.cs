using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorAtacar : MonoBehaviour
{

    [SerializeField] public JugadorController jugadorController;
    [SerializeField] private GameObject bala;
    [SerializeField] Transform PuntodeDisparo;
    [SerializeField] float tiempoEntreDisparos = 0f;
    public bool PresionandoDisparar = false;
    public bool Disparar = false;



    void Start()
    {
        jugadorController = GetComponent<JugadorController>();
    }

    public void Disparo(bool var)
    {
        StartCoroutine(Atacando());
        PresionandoDisparar = var;
        if (EstadoDisparo() == true && PresionandoDisparar == true && Disparar == true)
        {
            Instantiate(bala, PuntodeDisparo.position, PuntodeDisparo.rotation);
        }
    }

    public bool EstadoDisparo()
    {

        bool Suelo = GameManager.gameManager.jugadorManager.jugadorController.movimiento.Suelo();
        float Quieto = Mathf.Abs(GameManager.gameManager.jugadorManager.jugadorController.movimiento.MovimientoHorizontal);

        if (Suelo == true && Quieto < 0.1)
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    private IEnumerator Atacando()
    {
        if (!Disparar)
        {
            Disparar = true;
            yield return new WaitForSeconds(tiempoEntreDisparos);
            Disparar = false;
        }
    }

}
