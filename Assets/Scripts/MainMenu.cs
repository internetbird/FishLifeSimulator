using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


    public void StartSimulation()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitSimulation()
    {
        Debug.Log("Quitting application");
        Application.Quit();
    }
}
