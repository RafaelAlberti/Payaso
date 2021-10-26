using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    public Pausa MenuPausa;
    public HUD hud;

    void Start()
    {
        this.MenuPausa = GetComponent<Pausa>();
        this.hud = GetComponent<HUD>();
    }
}
