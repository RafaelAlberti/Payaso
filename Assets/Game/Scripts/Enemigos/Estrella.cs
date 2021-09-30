using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrella : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float velocidad;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        MovimientoEstrella();
        DestruccionEstrella();
    }

    private void MovimientoEstrella()
    {
        rb2d.velocity = transform.right * velocidad;

    }

    private void DestruccionEstrella()
    {
        Destroy(this.gameObject, 1f);
    }
}
