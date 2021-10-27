using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMuere : MonoBehaviour
{
    [SerializeField] EnemigoController enemigoController;
    void Start()
    {
        this.enemigoController = GetComponent<EnemigoController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
