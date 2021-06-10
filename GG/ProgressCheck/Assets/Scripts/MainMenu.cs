using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int lives = 3;
    public void LoadStart()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.SetInt("Lives", lives);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
