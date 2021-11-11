using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJefe : MonoBehaviour
{
    private int VidaMaxima = 10;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bala"))
        {
            QuitarVidaJefe();

            if (VidaMaxima <= 0)
            {
                Muerte();
            }
        }
    }


    public void Muerte()
    {
        Destroy(this.gameObject);
    }
    void QuitarVidaJefe()
    {
        VidaMaxima--;
    }
}
