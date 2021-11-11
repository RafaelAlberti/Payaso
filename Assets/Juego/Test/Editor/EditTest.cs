using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EditTest
{
   


    [Test]
    public void SpawnPersonaje()
    {
        GameObject gameManager = new GameObject();
        GameManager instanciaGameManager = gameManager.AddComponent<GameManager>();
        int vidapersonaje = GameManager.gameManager.UIManager.UIcontroller.hud.VidaMaxima;
        Assert.AreEqual(vidapersonaje, 3);
    }

    [UnityTest]
    public IEnumerator EditTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
