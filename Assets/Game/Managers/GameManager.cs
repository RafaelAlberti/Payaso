using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public JugadorManager jugadorManager;
    public UIManager UIManager;
    public  int MonedasTotalesPropiedad { get { return monedasTotales; } }
    private int monedasTotales;
  
    public void Awake()
    {
        if (GameManager.gameManager == null)
        {
            GameManager.gameManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else 
        {
            Destroy(this.gameObject);
        }

    }


   void Start()
   {
        CargarManager();
        jugadorManager.SpawnDePersonaje();
        
   }

  

    public void SumarMonedas(int monedasSumar)
    {
      this.monedasTotales += monedasSumar;
        
    }



    public void GuardarPartida()
    {
        InformacionPartida.payaso.CantidadMonedas = monedasTotales;
        InformacionPartida.payaso.Vida = UIManager.UIcontroller.hud.VidaMaxima;
        InformacionPartida.payaso.posicion = GameObject.Find("Payaso(Clone)").GetComponent<JugadorController>().transform.position;
    }

    public void CargarPartida()
    {
        monedasTotales = InformacionPartida.payaso.CantidadMonedas;
        UIManager.UIcontroller.hud.VidaMaxima = InformacionPartida.payaso.Vida;
        GameObject.Find("Payaso(Clone)").GetComponent<JugadorController>().transform.position = InformacionPartida.payaso.posicion;

    }


    void CargarManager()
    {
        this.UIManager = GameObject.FindObjectOfType<UIManager>();
        this.jugadorManager = GameObject.Find("Jugador").GetComponent<JugadorManager>();
        Time.timeScale = 1f;
    }

    public void Nivel()
    {
        Invoke("CargarManager", 1f);
        Invoke("jugadorManager.SpawnDePersonaje", 1f);
        Destroy(this.gameObject);
    }
 
    
}
