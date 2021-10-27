using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDisparo : MonoBehaviour
{
    [SerializeField] EnemigoController enemigoController;
    [SerializeField] private GameObject Shuriken;
    [SerializeField] Transform PuntodeDisparo;
    [SerializeField] private float TiempoEntreDisparos;
    private float Contador;
    public bool EstadoAtaque = false;
    
    void Start()
    {
        this.enemigoController = GetComponent<EnemigoController>();
    }

   
    public void Disparo()
    {
        Contador += Time.deltaTime;
        if ( Contador > TiempoEntreDisparos && EstadoAtaque == true)
        {
            GameObject Bala = (GameObject)Instantiate(Shuriken, PuntodeDisparo.position, PuntodeDisparo.rotation);
            Contador = 0;
        }
    }




}
