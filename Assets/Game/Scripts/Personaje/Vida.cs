using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public Image corazon;
    public int cantidadCorazones;
    public RectTransform PosicionCorazonInicial;
    public Canvas HUD;
   [SerializeField,Range(0,120)] private int Interlineado;
    
    void Start()
    {

        vida();
    } 

    
    void Update()
    {
        
        if(cantidadCorazones <= 0)
        {
            Destroy(gameObject);
            Destroy(corazon);
        }

    }


    private void vida()
    {
        Transform PosicionCor = PosicionCorazonInicial;

        for (int i = 0; i < cantidadCorazones; i++)
        {
            Image NewCorazon = Instantiate(corazon, PosicionCor.position, Quaternion.identity);
            NewCorazon.transform.SetParent(HUD.transform);
            PosicionCor.position = new Vector2(PosicionCor.position.x + Interlineado, PosicionCor.position.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Estrella")
        {
            Destroy(HUD.transform.GetChild(cantidadCorazones + 1).gameObject);
            cantidadCorazones = -1;
            Destroy(collision.gameObject);
        }
    }
}
