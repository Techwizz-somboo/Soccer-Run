using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniMenu : MonoBehaviour {

    public void Help()
    {
        SceneManager.LoadScene("MiniHelp", LoadSceneMode.Additive);
        SceneManager.UnloadScene("MiniMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
