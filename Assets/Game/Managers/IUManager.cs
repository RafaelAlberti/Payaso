using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IUManager : MonoBehaviour
{
    public MenuManager menuManager;

    private void Start()
    {
       this.menuManager = GetComponent<MenuManager>();
    }
}
