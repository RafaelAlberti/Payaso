using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GloboVerde : MonoBehaviour
{
    public Image corazon;
    public int cantidadCorazones;
    public RectTransform PosicionCorazonInicial;
    public Canvas HUD;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(HUD.transform.GetChild(cantidadCorazones + 1).gameObject);
            cantidadCorazones = -1;
            Destroy(this.gameObject);

        }
    }
}