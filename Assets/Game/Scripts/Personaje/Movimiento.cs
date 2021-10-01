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
    private Animator Animator;
    private Vector2 Direccion;
    private Rigidbody2D rgb2d;
    [SerializeField]private LayerMask capaSuelo;


    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        Animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        Morir();
        Moverse();
        Saltar();
    }

    void FixedUpdate()
    {
        Animacion();
    }

    public void OnMoverse(InputValue valor)
    {
        this.Direccion = valor.Get<Vector2>();
        
    }

    bool Suelo()
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
        if (Suelo() == true)
        {
          rgb2d.velocity = new Vector2(rgb2d.velocity.x, salto * Direccion.y);
        }
    }


    public void Morir()
    {
        if (Muerte.MuertePersonaje == true)
        {
            Animator.SetBool("Muerte", Muerte.MuertePersonaje);
        }
    }

    public void Animacion()
    {
        Animator.SetFloat("Velocidad", Mathf.Abs(Direccion.x));
        Animator.SetBool("Suelo",Suelo());
        Animator.SetBool("Disparar", Disparar.DisparoEstado);
    }
   
}
