using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShruikenGigante : MonoBehaviour
{
    [SerializeField] private float velocidad = 18f;
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

    public void MovimientoShuriken()
    {
        rb2d.velocity = transform.right * velocidad;
    }

    private void DestruccionShuriken()
    {

        Destroy(this.gameObject, 1.5f);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            RestarVidas(); 
        }
    }


    public  void RestarVidas()
    {
        GameManager.gameManager.jugadorManager.jugadorController.RecibirdañoJefe();
    }


}
