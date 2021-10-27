using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovimiento : MonoBehaviour
{
    [SerializeField]EnemigoController enemigoController;
    [SerializeField] private Rigidbody2D rgb2d;

    void Start()
    {
        this.rgb2d = GetComponent<Rigidbody2D>();
        this.enemigoController = GetComponent<EnemigoController>();
    }

    
    void Update()
    {
        
    }
}
