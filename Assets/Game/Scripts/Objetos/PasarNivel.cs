using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarNivel : MonoBehaviour
{

    [SerializeField] private string nombreDelNivel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.gameManager.DestruirGame();
            SceneManager.LoadScene(nombreDelNivel,LoadSceneMode.Single);
        }
    }
}
