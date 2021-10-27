using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoManager : MonoBehaviour
{
    
    public EnemigoController enemigoController;
    
    void Start()
    {
       this.enemigoController = GetComponent<EnemigoController>();
    }

   
    void Update()
    {
        
    }
}
