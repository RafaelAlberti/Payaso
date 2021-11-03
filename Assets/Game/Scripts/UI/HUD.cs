using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] UIcontroller UIcontroller;
    public TextMeshProUGUI monedas;
    public GameObject Perdiste;
    public GameObject[] VidaCorazones;
    public int VidaMaxima = 3;

    private void Start()
    {
        VidaMaxima = VidaCorazones.Length;
    }

    void Update()
    {
        MostrarMonedas();
    }

    private void MostrarMonedas()
    {
        monedas.text = GameManager.gameManager.MonedasTotalesPropiedad.ToString();
    }


    public void QuitarVidas()
    {
        if (VidaMaxima < 1)
        {
            VidaCorazones[0].SetActive(false);
        }
        else if(VidaMaxima < 2)
        {
            VidaCorazones[1].SetActive(false);
        }
        else if(VidaMaxima < 3)
        {
            VidaCorazones[2].SetActive(false);
        }
    }

    public void AgregarVidas()
    {
        if (VidaMaxima >= 1 && VidaMaxima <= 2)
        {
            VidaCorazones[1].SetActive(true);
        }
        else if (VidaMaxima >= 2 && VidaMaxima <= 3)
        {
            VidaCorazones[2].SetActive(true);
        }
    }


    public void HacerDanio()
    {
        VidaMaxima--;
    }

    public void Curar()
    {
        VidaMaxima++;
    }


    public void muerte()
    {
        Perdiste.SetActive(true);
    }

    public void vive()
    {
        
    }

}
