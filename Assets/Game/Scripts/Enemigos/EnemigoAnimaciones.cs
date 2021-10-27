using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAnimaciones : MonoBehaviour
{
    [SerializeField] EnemigoController enemigoController;
    void Start()
    {
        this.enemigoController = GetComponent<EnemigoController>();
    }

    
    void Update()
    {
        
    }
}
