using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSonido : MonoBehaviour
{
    [SerializeField] MenuController menuController;
    void Start()
    {
        menuController = GetComponent<MenuController>();
    }

    
    void Update()
    {
        
    }
}
