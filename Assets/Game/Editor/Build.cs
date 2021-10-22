using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Build : MonoBehaviour
{
	public static string version = System.Environment.GetEnvironmentVariable("projectVersion");
	public static string gameName = System.Environment.GetEnvironmentVariable("gameName");

	public static void BuildWindows64()
	{
		string buildPath = ".\\Builds\\" + version + "\\Win64\\" + gameName + ".exe";
		BuildPipeline.BuildPlayer(
			new string[]
			{
			"Assets\\Menu\\Scenes\\MenuPrincipal",
			"Assets\\Menu\\Scenes\\Opciones",
			"Assets\\Game\\Scenes\\Nivel-1.unity",
			"Assets\\Game\\Scenes\\Nivel-2.unity", 
			"Assets\\Game\\Scenes\\Nivel-3.unity"
			},
			buildPath,
			BuildTarget.StandaloneWindows64,
			BuildOptions.None
		);
	}

	public static void BuildWindows32()
	{
		string buildPath = ".\\Builds\\" + version + "\\Win32\\" + gameName + ".exe";
		BuildPipeline.BuildPlayer(
			new string[]
			{
			"Assets\\Menu\\Scenes\\MenuPrincipal",
			"Assets\\Menu\\Scenes\\Opciones",
			"Assets\\Game\\Scenes\\Nivel-1.unity",
			"Assets\\Game\\Scenes\\Nivel-2.unity",
			"Assets\\Game\\Scenes\\Nivel-3.unity"
			},
			buildPath,
			BuildTarget.StandaloneWindows,
			BuildOptions.None
		);
	}


}
