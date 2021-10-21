using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public JugadorManager jugadorManager;
    public int MonedasTotales { get { return monedasTotalesSumadas; } }
    private int monedasTotalesSumadas;
   
  


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

        this.jugadorManager = GameObject.Find("Jugador").GetComponent<JugadorManager>();
        this.jugadorManager.SpawnDePersonaje();
    }

    public void SumarMonedas(int monedasSumar)
    {
      this.monedasTotalesSumadas += monedasSumar;
        
    }

  
    
    void Update()
    {
      
    }
}
