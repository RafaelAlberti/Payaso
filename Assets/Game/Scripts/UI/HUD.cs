using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{

    public GameManager gameManager;
    public TextMeshProUGUI monedas;

   
    void Update()
    {
        monedas.text = gameManager.MonedasTotales.ToString();
    }
}
