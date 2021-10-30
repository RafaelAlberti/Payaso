using System;
using UnityEngine;

public class EnemigoMovimiento : MonoBehaviour
{
    [SerializeField] EnemigoController enemigoController;
    [SerializeField] public Rigidbody2D rgb2d;
    [SerializeField] public CircleCollider2D area;
    [SerializeField, Range(1, 120)] public float velocidad = 5.0f;
    [NonSerialized] public float moverse;
    float LimiteDer;
    float LimiteIzq;
    public int Direccion = -1;

    

    void Start()
    {
        this.rgb2d = GetComponent<Rigidbody2D>();
        this.area = GetComponent<CircleCollider2D>();
        this.enemigoController = GetComponent<EnemigoController>();
        this.LimiteDer = transform.position.x + this.area.radius;
        this.LimiteIzq = transform.position.x - this.area.radius;
    }


    public void Moverse()
    {
        rgb2d.velocity = new Vector2(velocidad * Direccion, rgb2d.velocity.y);
        moverse = rgb2d.velocity.x;
        Orientacion(); 
    }

    public void Orientacion()
    {
        if (transform.position.x < LimiteIzq)
        {
            Direccion = 1;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (transform.position.x > LimiteDer)
        {
            Direccion = -1;
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }


}
