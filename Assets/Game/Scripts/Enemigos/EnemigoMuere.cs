using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMuere : MonoBehaviour
{
    [SerializeField] EnemigoController enemigoController;
   


    public void Start()
    {
        enemigoController = GetComponent<EnemigoController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bala"))
        {
            Muerte();
        }

        if (collision.CompareTag("Player"))
        {
            Muerte();
        }

    }


    public void Muerte()
    {
      Destroy(this.gameObject);
    }


}
