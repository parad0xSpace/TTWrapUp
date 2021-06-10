using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        int reset = 0;
        //PlayerPrefs.GetInt("xp", reset);
        PlayerPrefs.GetInt("effectValue", reset);
        PlayerPrefs.GetString("reagentAdded", "");
        PlayerPrefs.GetString("potionRQ", "");
        PlayerPrefs.GetInt("acceptedQuest", 0);
        SceneManager.LoadScene("RequestScene");
    }

    public void ContinueGame()
    {
        if(PlayerPrefs.GetString("lastscene") != "")
        {
            SceneManager.LoadScene(PlayerPrefs.GetString("lastscene"));
        }
        else
        {
            SceneManager.LoadScene("RequestScene");
        }
    }

    public void ExitGame()
    {
        //close application
    }
}
