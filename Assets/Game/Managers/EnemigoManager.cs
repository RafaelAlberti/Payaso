using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoManager : MonoBehaviour
{

    [SerializeField] private GameObject Enemigo;
    public EnemigoController enemigoController;



    public void start()
    {
        this.Enemigo.transform.parent = GameObject.Find("Ninjas").transform;
        this.enemigoController = Enemigo.GetComponent<EnemigoController>();
    }

}
