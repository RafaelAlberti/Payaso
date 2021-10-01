using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GloboRojo : MonoBehaviour
{
    public Image corazon;
    public RectTransform PosicionCorazonInicial;
    public Canvas HUD;
    [SerializeField, Range(0, 120)] private int Interlineado;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Transform PosicionCor = PosicionCorazonInicial;

            Image NewCorazon = Instantiate(corazon, PosicionCor.position, Quaternion.identity);

            NewCorazon.transform.SetParent(HUD.transform);

            PosicionCor.position = new Vector2(PosicionCor.position.x + Interlineado, PosicionCor.position.y);
            Destroy(this.gameObject);
        }
    }
}
