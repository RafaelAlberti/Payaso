using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSonido : MonoBehaviour
{
    public Slider slider;
    public float sliderValor;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("VolumenAudio", 0.5f);
        AudioListener.volume = slider.value;
    }


    public void Volumen(float valor)
    {
        sliderValor = valor;
        PlayerPrefs.SetFloat("VolumenAudio", sliderValor);
        AudioListener.volume = slider.value;
    }


}
