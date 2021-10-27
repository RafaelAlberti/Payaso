using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour
{
    [SerializeField] private float velocidad = 6.0f;
    private Rigidbody2D rb2d;
    
  
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        MovimientoShuriken();
        DestruccionShuriken();
      
    }

    private void MovimientoShuriken()
    {
      rb2d.velocity = transform.right * velocidad;
    }

    private void DestruccionShuriken()
    {
      Destroy(this.gameObject, 1f);
    }



}
