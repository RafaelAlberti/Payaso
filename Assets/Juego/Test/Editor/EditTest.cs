using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EditTest
{

    [Test]
    public void VidaPersonaje()
    {
        int vidaPersonaje = GameManager.gameManager.UIManager.UIcontroller.hud.VidaMaxima;
        Assert.Equals(vidaPersonaje, 3);
    }


    [Test]
    public void SumarMonedas()
    {
       GameObject gameManager = new GameObject();
       gameManager.GetComponent<GameManager>().SumarMonedas(); 
       int Monedas = GameManager.gameManager.MonedasTotalesPropiedad;
       Assert.GreaterOrEqual(Monedas, 1);
    }

    [Test]
    public void HacerDaño()
    {
        int vidaPersonaje = GameManager.gameManager.UIManager.UIcontroller.hud.VidaMaxima;
        GameManager.gameManager.UIManager.UIcontroller.hud.HacerDanio();
        Assert.LessOrEqual(vidaPersonaje, 2);
    }

    [Test]
    public void VidaDelJefe()
    {
        VidaJefe vida = new VidaJefe();

        int VidaTotal = vida.VidaMaxima;

        Assert.Equals(VidaTotal, 10);

    }
}