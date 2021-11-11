using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public MenuBotones Botones;
    public MenuSonido Sonido;
    public MenuOpciones Opciones;

    void Start()
    {
        this.Botones = GetComponent<MenuBotones>();
        this.Sonido = GetComponent<MenuSonido>();
        this.Opciones = GetComponent<MenuOpciones>();
    }

}
