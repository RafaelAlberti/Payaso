using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager menuManagerInstancia;
    public MenuController menuController;

    private void Awake()
    {
        if (MenuManager.menuManagerInstancia == null)
        {
            MenuManager.menuManagerInstancia = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    private void Start()
    {
        this.menuController = GetComponent<MenuController>();
    }

    public void DestruirMenu()
    {
       Destroy(this.gameObject);
    }
}
