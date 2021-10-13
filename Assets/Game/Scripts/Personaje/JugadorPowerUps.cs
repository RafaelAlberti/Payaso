using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorPowerUps : MonoBehaviour
{
   
    void Start()
    {
        
    }


    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (tag)
        {
            case "Rojo":
                GloboRojo();
                 break;

            case "Azul":
                GloboAzul();
                break;

            case "Verde":
                GloboVerde();
                break;
        }

    }


    public void GloboRojo()
    {
        Debug.Log("Hola; Yo soy el globo rojo con el nuevo sistema");
    }


    public void GloboAzul()
    {
        Debug.Log("Hola, Yo soy el globo azul con el nuevo sistema");
    }


    public void GloboVerde()
    {
        Debug.Log("Hola; Yo soy el globo verde con el nuevo sistema");
    }


}
