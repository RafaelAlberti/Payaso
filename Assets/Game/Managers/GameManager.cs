using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public JugadorManager jugadorManager;
    public EnemigoManager enemigoManager;
    public UIManager UIManager;
    public  int MonedasTotalesPropiedad { get { return monedasTotales; } }
    private int monedasTotales;
    public  int indexer = 0;
  
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

    private void Update()
    {
    }


    public void SumarMonedas(int monedasSumar)
    {
      this.monedasTotales += monedasSumar;
        
    }


    void CargarManager()
    {
        this.enemigoManager = GameObject.FindObjectOfType<EnemigoManager>();
        this.UIManager = GameObject.FindObjectOfType<UIManager>();
        this.jugadorManager = GameObject.Find("Jugador").GetComponent<JugadorManager>();
    }

    public void Nivel()
    {
        Invoke("CargarManager", 1f);
        Invoke("jugadorManager.SpawnDePersonaje", 1f); Destroy(this.gameObject);
    }
 
}
