using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMovimiento : MonoBehaviour
{
    [SerializeField] JugadorController jugadorController;
    [SerializeField] LayerMask capaSuelo;
    [SerializeField, Range (0, 120)] float salto;
    [SerializeField, Range(0, 120)]  float velocidad;
    private Rigidbody2D rgb2d;
    private BoxCollider2D boxCollider;
    float MovimientoHorizontal;
    

    void Start()
    {
        this.jugadorController = GetComponent<JugadorController>();
        this.rgb2d = GetComponent<Rigidbody2D>();
        this.boxCollider = GetComponent<BoxCollider2D>();
    }


    public void Moverse(float var)
    {
        MovimientoHorizontal = var;
        rgb2d.velocity = new Vector2(MovimientoHorizontal * velocidad, rgb2d.velocity.y);
        Orientacion();
    }


    public void Saltar()
    {
        if (Suelo() == true)
        {
            rgb2d.velocity = new Vector2(rgb2d.velocity.x, salto);
        }
    }


    public void Orientacion()
    {
        if (rgb2d.velocity.x > 0)
        {
            rgb2d.transform.localScale = new Vector3(1, 1, 1);

        }
        else if (rgb2d.velocity.x < 0)
        {
            rgb2d.transform.localScale = new Vector3(-1, 1, 1);
        }
        
    }


    public bool Suelo()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(boxCollider.bounds.center,
                               new Vector2(boxCollider.bounds.size.x,boxCollider.bounds.size.y)
                               ,0f, Vector2.down, 0.2f, capaSuelo);

        return raycast.collider != null;
    }

   
}
