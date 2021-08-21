using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        { 

            Debug.Log("Era un powerUP?");
            Destroy(gameObject, 0.2f);
            


        }

    }
}
