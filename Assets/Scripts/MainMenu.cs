using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene("Developer Playground");
	}
	public void Help ()
	{
		SceneManager.LoadScene ("HelpMenu");
	}
	public void Quit ()
	{
		Application.Quit();
	}
}
