using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar : MonoBehaviour
{
    [SerializeField] private GameObject Ganaste;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            Time.timeScale = 0;
            Ganaste.SetActive(true);

            Destroy(gameObject, 0.2f);


        }

    }
}
