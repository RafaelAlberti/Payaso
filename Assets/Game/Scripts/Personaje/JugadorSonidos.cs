using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorSonidos : MonoBehaviour
{
    [SerializeField] JugadorController jugadorController;
    public GameObject disparo;
    public GameObject Salto;
    public GameObject globo;
    public GameObject moneda;
    [SerializeField] Transform Payaso;
    void Start()
    {
        jugadorController = GetComponent<JugadorController>();
    }

    private void Update()
    {
        Payaso = GameObject.Find("Payaso(Clone)").GetComponent<JugadorController>().transform;
    }
    public void SonidoDisparo()
    {
        GameObject bala = jugadorController.atacar.bala;
        Destroy(Instantiate(disparo, bala.transform.position, Quaternion.identity), 0.1f);
    }
    public void SonidoSalto()
    {
        Destroy(Instantiate(Salto, Payaso.position, Quaternion.identity), 1f);
    }

    public void SonidoGlobo()
    {
        Destroy(Instantiate(globo, Payaso.position, Quaternion.identity), 0.4f);
    }

    public void SonidoMoneda()
    {
        Destroy(Instantiate(moneda, Payaso.position, Quaternion.identity), 1f);
    }
}
