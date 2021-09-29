using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int MonedasTotales { get { return monedasTotales; } }
    private int monedasTotales;


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
