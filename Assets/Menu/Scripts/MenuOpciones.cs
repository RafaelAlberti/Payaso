using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOpciones : MonoBehaviour
{
    public Slider slider;
    public float SliderVolumen;
    public Image ImagenMute;


    [SerializeField] MenuController menuController;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("VolumenAudio", 0.5f);
        menuController = GetComponent<MenuController>();
    }

    
    void Update()
    {
        
    }
}
