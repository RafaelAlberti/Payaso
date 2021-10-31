using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{ 
   
    public static bool MuertePersonaje;
    [SerializeField] private GameObject Perdiste;



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && MuertePersonaje == false)
        {
            MuertePersonaje = true;
            Perdiste.SetActive(true);
            Time.timeScale = 0;
        }


    }



    private void Update()
    {
        // MuerteFinal();
    }


    public void MuerteFinal()
    {

        /**if (MuertePersonaje == true && vida.cantidadCorazones == 0)
        {
            Perdiste.SetActive(true);
            Time.timeScale = 0;
        }**/
    }

}
