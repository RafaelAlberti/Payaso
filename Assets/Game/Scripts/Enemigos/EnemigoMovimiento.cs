using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovimiento : MonoBehaviour
{
    [SerializeField]EnemigoController enemigoController;
    [SerializeField] private Rigidbody2D rgb2d;
    [SerializeField, Range (1,120)]float Velocidad = 5.0f;
    float LimiteCaminataDer;
    float LimiteCaminataIzq;
    int direccion = 1;
    
    void Start()
    {
        this.rgb2d = GetComponent<Rigidbody2D>();
        this.LimiteCaminataDer = transform.position.x + GetComponent<CircleCollider2D>().radius;
        this.LimiteCaminataIzq = transform.position.x - GetComponent<CircleCollider2D>().radius;
    }

    
    void Update()
    {
        rgb2d.velocity = new Vector2(Velocidad * direccion, rgb2d.velocity.y);
        if (transform.position.x < LimiteCaminataIzq) direccion = 1;
        if (transform.position.x > LimiteCaminataDer) direccion = -1;
        transform.localScale = new Vector3(-1f * direccion, 1f, 1f);
    }

   

}
