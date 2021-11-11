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
    public GameObject VidaObjeto;
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
        if (VidaMaxima < 1 )
        {
            VidaCorazones[VidaMaxima].SetActive(false);
        }
        else if(VidaMaxima < 2)
        {
            VidaCorazones[VidaMaxima].SetActive(false);
        }
        else if(VidaMaxima < 3)
        {
            VidaCorazones[VidaMaxima].SetActive(false);
        }
    }

    public void AgregarVidas()
    {
        if (VidaMaxima >= 1 && VidaMaxima <= 2)
        {
            VidaCorazones[VidaMaxima].SetActive(true);
        }
        else if (VidaMaxima >= 2 && VidaMaxima <= 3)
        {
            VidaCorazones[VidaMaxima].SetActive(true);
        }
    }


    public void HacerDanio()
    {
        VidaMaxima--;
    }

    public void DañoJefe()
    {
        VidaMaxima -= 3;
    }


    public void Curar()
    {
        VidaMaxima++;
    }


    public void muerte()
    {
        Perdiste.SetActive(true);
        VidaObjeto.SetActive(false);
    }

    public void vive()
    {
        Perdiste.SetActive(false);
    }

}
