using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel : MonoBehaviour
{

    [SerializeField] private string nombreDelNivel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.gameManager.Nivel();
            InputManager.InputManagerInstanciado.OnDestroy();
            SceneManager.LoadScene(nombreDelNivel,LoadSceneMode.Single);
        }
    }
}
