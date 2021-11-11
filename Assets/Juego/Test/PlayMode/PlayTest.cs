using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using UnityEngine.SceneManagement;


public class PlayTest
{

    [Test]
    public void CargarMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    [Test]
    public void CargarPrimerEscena()
    {
        SceneManager.LoadScene("Nivel-1");
    }


    [UnityTest]
    public IEnumerator SpawnPersonaje()
    {
        GameObject Jugador = GameObject.Find("Payaso(Clone)");
        yield return null;
        Assert.NotNull(Jugador);
    }

    [UnityTest]
    public IEnumerator MoverPersonaje()
    {
        GameObject Jugador = GameObject.Find("Payaso(Clone)");
        float PosicionInicialX = Jugador.transform.position.x;
        float PosicionFinalX = PosicionInicialX + 10;
        yield return new WaitForSeconds(1);
        Assert.NotNull(Jugador);
        Assert.Greater(PosicionFinalX, 10);
    }

    [UnityTest]
    public IEnumerator SaltarPersonaje()
    {
        GameObject Jugador = GameObject.Find("Payaso(Clone)");
        float PosicionInicialY = Jugador.transform.position.y;
        float PosicionEsperadaY = PosicionInicialY + 10;
        Jugador.GetComponent<JugadorMovimiento>().Saltar();
        yield return new WaitForSeconds(1);
        Assert.Greater(PosicionEsperadaY, 4);
    }

    [UnityTest]
    public IEnumerator DispararPersonaje()
    {
        GameObject Jugador = GameObject.Find("Payaso(Clone)");
        float PosicionInicialY = Jugador.transform.position.y;
        float PosicionEsperadaY = PosicionInicialY + 10;
        Jugador.GetComponent<JugadorAtacar>().Disparo();
        bool disparo = Jugador.GetComponent<JugadorAtacar>().Disparar;
        yield return new WaitForSeconds(1);
        Assert.IsTrue(disparo);
    }
}
