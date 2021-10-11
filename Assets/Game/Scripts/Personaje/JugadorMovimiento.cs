using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMovimiento : MonoBehaviour
{

    [SerializeField] private LayerMask capaSuelo;
    [SerializeField] private float salto = 7.0f;
    [SerializeField] private float velocidad = 5.0f;
    public Vector2 Direccion;
    private Rigidbody2D rgb2d;
    private BoxCollider2D boxCollider;
    


    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    public void Moverse()
    {
        rgb2d.velocity = new Vector2(Direccion.x * velocidad, rgb2d.velocity.y);

        Orientacion();
    }


    void Orientacion()
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
    public void Saltar()
    {
        if (Suelo() == true)
        {
            rgb2d.velocity = new Vector2(rgb2d.velocity.x, salto * Direccion.y);
        }
    }

}
