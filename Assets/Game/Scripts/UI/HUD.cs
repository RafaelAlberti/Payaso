using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    [SerializeField] UIcontroller UIcontroller;
    public TextMeshProUGUI monedas;
    


    void Update()
    {
        MostrarMonedas();
    }

    private void MostrarMonedas()
    {
        monedas.text = GameManager.gameManager.MonedasTotalesPropiedad.ToString();
    }

}
