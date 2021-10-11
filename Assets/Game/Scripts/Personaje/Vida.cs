using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public Image corazon;
    public int cantidadCorazones = 1;
    public RectTransform PosicionCorazonInicial;
    public Canvas HUD;
   [SerializeField,Range(0,120)] private int Interlineado;
    

    void Start()
    {
      vida();
    } 

    
    void Update()
    {
        
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

 


}

