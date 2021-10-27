using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jefe : MonoBehaviour
{
   [SerializeField] private GameObject Continuara;
   [SerializeField] private GameObject HUB;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Continuara.SetActive(true);
            HUB.SetActive(false);
            Time.timeScale = 0;
        }

    }
}
