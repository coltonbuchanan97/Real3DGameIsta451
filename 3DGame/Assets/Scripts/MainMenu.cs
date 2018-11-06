using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string playGamelevel;
    public string controlMenu;
    public string aboutMenu;

    public void Load()
    {
        SceneManager.LoadScene(playGamelevel);
    }

    public void Controls()
    {
        SceneManager.LoadScene(controlMenu);
    }

    public void About()
    {
        SceneManager.LoadScene(aboutMenu);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void RestartGame(){

        FindObjectOfType<GameManager>().Death();
            
    }
}
