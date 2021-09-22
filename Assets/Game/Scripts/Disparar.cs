using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Disparar : MonoBehaviour
{

    PlayerInput Input;
    [SerializeField] Transform PuntodeDisparo;
    [SerializeField] private GameObject bala;
    

    void Start()
    {
        Input = GetComponent<PlayerInput>();
    }

    
    void Update()
    {
        
    }

    public void OnAtacar()
    {
        Instantiate(bala, PuntodeDisparo.position, Quaternion.identity);
    }
   
 
}
