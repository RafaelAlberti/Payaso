using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    }

    public void GloboAzul()
    {

    }

    public void GloboVerde()
    {

    }

}
