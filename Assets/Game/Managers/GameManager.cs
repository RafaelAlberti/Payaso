using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public int MonedasTotales { get { return monedasTotales; } }
    private int monedasTotales;
   
  


    public void Awake()
    {
       if(GameManager.gameManager == null)
        {
            GameManager.gameManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
       else 
        {
            Destroy(this.gameObject);
        }
    }



    public void SumarMonedas(int monedasSumar)
    {
        monedasTotales += monedasSumar;
        
    }



    void Start()
    {
     
    }

    
    void Update()
    {
      
    }
}
