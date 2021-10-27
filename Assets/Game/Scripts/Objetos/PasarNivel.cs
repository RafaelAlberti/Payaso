using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarNivel : MonoBehaviour
{

    [SerializeField] private string nombreDelNivel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(nombreDelNivel);
        }
    }
}
