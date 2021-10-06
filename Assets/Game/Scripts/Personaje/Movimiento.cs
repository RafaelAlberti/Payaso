using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movimiento : MonoBehaviour
{
    PlayerInput playerInput;
    private BoxCollider2D boxCollider;
    [SerializeField]private float salto = 7.0f;
    [SerializeField]private float velocidad = 5.0f;
    public  Vector2 Direccion;
    private Rigidbody2D rgb2d;
    private float Potencia;
    [SerializeField]private LayerMask capaSuelo;


    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
       Moverse();
       Saltar();
    }

   

    public void OnMoverse(InputValue valor)
    {
       Direccion = valor.Get<Vector2>();
        
    }

  public bool Suelo()
    {
       RaycastHit2D raycast =  Physics2D.BoxCast(boxCollider.bounds.center,
           new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y),
           0f, Vector2.down, 0.2f, capaSuelo);

        return raycast.collider != null;
    }

    public void Moverse()
    {
        rgb2d.velocity = new Vector2(Direccion.x * velocidad, rgb2d.velocity.y);
        
        Orientacion();
    }


   void Orientacion() {
        if (rgb2d.velocity.x > 0)
        {
            rgb2d.transform.localScale = new Vector3(1,1,1);

        } else if (rgb2d.velocity.x < 0 )
        {
            rgb2d.transform.localScale = new Vector3(-1,1,1);
        }

    }


    public void Saltar()
    {
        Debug.Log(Direccion.y);

        if (Suelo() == true)
        {
          rgb2d.velocity = new Vector2(rgb2d.velocity.x, salto * direccion(Direccion.y));
        }
    }



    float direccion(float salto)
    {
        if (salto < 1)
        {
           float diferencia = 1 - salto;
           Potencia = diferencia + salto;
        }

        return Potencia;
    }

    
}
