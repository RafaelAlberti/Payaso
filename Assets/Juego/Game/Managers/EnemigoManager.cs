using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoManager : MonoBehaviour
{
   
    public EnemigoController enemigoController;
 
   
    public void Start()
    {
        enemigoController = GetComponent<EnemigoController>();
    }


    

}
