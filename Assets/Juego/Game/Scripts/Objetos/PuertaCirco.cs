using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaCirco : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("Puerta", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("Puerta", false);
        }
    }
}
