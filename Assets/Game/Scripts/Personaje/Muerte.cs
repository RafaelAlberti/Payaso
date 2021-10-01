using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    [SerializeField] private GameObject Perdiste;
    public static bool MuertePersonaje = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Perdiste.SetActive(true);
            MuertePersonaje = true;
            Time.timeScale = 0;
        }

    }

    

   private void Update()
    {
       // MuerteFinal();
    }


    public void MuerteFinal() {

        /**if (MuertePersonaje == true && vida.cantidadCorazones == 0)
        {
            Perdiste.SetActive(true);
            Time.timeScale = 0;
        }**/
    } 


}
