using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RequestGenerator : MonoBehaviour
{

    string[] request;
    public Text requestText;
    string currentRequest;
    public static bool accepted = false;

    // Start is called before the first frame update
    void Start()
    {
        LoadRequest();
    }

    void LoadRequest()
    {
        string[] request = new string[] { "RED", "BLUE", "GOLD", "BIG", "SMALL", "FLOAT"};
        string randomRequest = request[Random.Range(0, request.Length)];
        currentRequest = randomRequest;
        requestText.text = "Hi! Can you brew a potion to make me " + randomRequest + "?";
        PlayerPrefs.GetString("potionRQ", currentRequest);
    }

    public void Accept()
    {
        accepted = true;
        PlayerPrefs.GetInt("acceptedQuest", 1);
        SceneManager.LoadScene("BrewScene");
    }

    public void Reject()
    {
        PlayerPrefs.GetInt("acceptedQuest", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
