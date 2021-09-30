using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    public Vida vida;
    public static bool MuertePersonaje = false;

    [SerializeField] private GameObject Perdiste;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            MuertePersonaje = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision ) 
    {

        if (collision.gameObject.tag == "Player")
        {
            MuertePersonaje = false;
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
