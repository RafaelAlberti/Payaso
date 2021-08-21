using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarSuelo : MonoBehaviour
{
    public static bool Suelo;


    private void OnTriggerEnter2D(Collider2D collision)
    {
     
         Suelo = true;
         //Debug.Log("tocando el suelo");
        
        
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        
          Suelo = false;
          //Debug.Log("ya no toco el suelo");

        
        
    }
}
