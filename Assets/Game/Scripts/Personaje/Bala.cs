using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    private Rigidbody2D rb2d;
    [SerializeField] private float velocidad;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
      MovimientoBala();
      DestruccionBala();
    }

    private void MovimientoBala()
    {
        rb2d.velocity = transform.right * velocidad;
        
    }

    private void DestruccionBala()
    {
        Destroy(this.gameObject, 1f);
    }


}