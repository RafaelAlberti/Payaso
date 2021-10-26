using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public MenuManager menuManager;
    public UIcontroller UIcontroller;
    private void Start()
    {
       this.menuManager = GetComponent<MenuManager>();
       this.UIcontroller = GetComponent<UIcontroller>();
    }
}
