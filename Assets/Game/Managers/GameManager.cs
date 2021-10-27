using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public JugadorManager jugadorManager;
    public EnemigoManager enemigoManager;
    public UIManager UIManager;
    public int MonedasTotalesPropiedad { get { return monedasTotales; } }
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
        this.enemigoManager = GameObject.FindObjectOfType<EnemigoManager>();
        this.UIManager = GameObject.FindObjectOfType<UIManager>();
        this.jugadorManager = GameObject.Find("Jugador").GetComponent<JugadorManager>();
        this.jugadorManager.SpawnDePersonaje();
    }

    public void SumarMonedas(int monedasSumar)
    {
      this.monedasTotales += monedasSumar;
        
    }

  
   
}
