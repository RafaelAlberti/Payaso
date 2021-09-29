using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
        public static bool MuertePersonaje;

    [SerializeField] private GameObject Perdiste;
    private void OnTriggerEnter2D(Collider2D collision)
        {

          if (collision.gameObject.tag == "Muerte")
          {
            MuertePersonaje = true;
            Perdiste.SetActive(true);
            Time.timeScale = 0;
        }

        }
    


}
