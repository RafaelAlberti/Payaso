using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMovimiento : MonoBehaviour
{
    [SerializeField] JugadorController jugadorController;
    [SerializeField] LayerMask capaSuelo;
    [SerializeField, Range (0, 120)] float salto;
    [SerializeField, Range(0, 120)]  float velocidad;
    [NonSerialized]public float MovimientoHorizontal;
    [SerializeField] private float TiempoPower;
    private Rigidbody2D rgb2d;
    private BoxCollider2D boxCollider;
    bool Azul;
    private float Contador;


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
            PowerVelocidad();
    }


    
    public void Saltar()
    {
        if (Suelo() == true)
        {
          rgb2d.AddForce(new Vector2(0, salto), ForceMode2D.Impulse);
        }
      
    }

    public void Orientacion()
    {
        if (rgb2d.velocity.x > 0)
        {
            rgb2d.transform.eulerAngles = new Vector3(0, 0, 0);

        }
        else if (rgb2d.velocity.x < 0)
        {
            rgb2d.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        
    }


    public bool Suelo()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(boxCollider.bounds.center,
                               new Vector2(boxCollider.bounds.size.x, 
                               boxCollider.bounds.size.y)
                               , 0f, Vector2.down, 0.2f, capaSuelo);

        return raycast;
    } 


    public void PowerVelocidad()
    {
        float var = velocidad;
        Azul = GameManager.gameManager.jugadorManager.jugadorController.powerUps.pw;
        Contador += Time.deltaTime;

        if (Contador > TiempoPower && Azul == true)
        {
           velocidad *= 2;
            GameManager.gameManager.jugadorManager.jugadorController.powerUps.pw = false;
        }
        else
        {
            velocidad = var;
        }

        

    }

}
