using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovimiento : MonoBehaviour
{
    [SerializeField]EnemigoController enemigoController;
    [SerializeField] public Rigidbody2D rgb2d;
    [SerializeField, Range(1, 120)] public float velocidad = 5.0f;
    float LimiteDer;
    float LimiteIzq;
    public int Direccion = -1;
    public bool Quieto;
    public float Correr;

    void Start()
    {
        this.rgb2d = GetComponent<Rigidbody2D>();
        this.enemigoController = GetComponent<EnemigoController>();
        LimiteDer = transform.position.x + GetComponent<CircleCollider2D>().radius;
        LimiteIzq = transform.position.x - GetComponent<CircleCollider2D>().radius;
    }


    public void Caminar()
    {
        Correr = rgb2d.velocity.x;
            rgb2d.velocity = new Vector2(velocidad * Direccion, rgb2d.velocity.y);
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
   
    bool ComprobarQuietud()
    {
        if (Mathf.Abs(rgb2d.velocity.x) < 0.1f)
        {
            return Quieto = true;
        }
        else
        {
            return Quieto = false;
        }

    }

}
