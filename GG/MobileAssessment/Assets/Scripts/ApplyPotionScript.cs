using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplyPotionScript : MonoBehaviour
{
    public GameObject customer;
    public Text customerText;
    public GameObject startEffectButton;
    public GameObject finishGameButton;
    int playthroughs;

    private void Start()
    {
        if (PlayerPrefs.GetInt("Playthroughs") != 0)
        {
            playthroughs = PlayerPrefs.GetInt("Playthroughs");
        }
    }

    public void ApplyEffect()
    {
        startEffectButton.gameObject.SetActive(false);
        finishGameButton.gameObject.SetActive(true);
        if(PlayerPrefs.GetString("reagentAdded") == "Leaf")
        {
            customer.gameObject.transform.localScale = customer.gameObject.transform.localScale * 2;
            if(PlayerPrefs.GetString("potionRQ") == "BIG")
            {
                Sucess();
            }
            else
            {
                Failure();
            }
        }
        else if(PlayerPrefs.GetString("reagentAdded") == "Berry")
        {
            customer.gameObject.transform.localScale = customer.gameObject.transform.localScale * .5f;
            if (PlayerPrefs.GetString("potionRQ") == "SMALL")
            {
                Sucess();
            }
            else
            {
                Failure();
            }
        }
        else if (PlayerPrefs.GetString("reagentAdded") == "Slime")
        {
            if (PlayerPrefs.GetString("potionRQ") == "FLOAT")
            {
                FloatSucess();
            }
            else
            {
                Failure();
            }
        }
        else if (PlayerPrefs.GetString("reagentAdded") == "Green")
        {
            customer.gameObject.GetComponent<Renderer>().material.color = Color.red;
            if (PlayerPrefs.GetString("potionRQ") == "RED")
            {
                Sucess();
            }
            else
            {
                Failure();
            }
        }
        else if (PlayerPrefs.GetString("reagentAdded") == "Orange")
        {
            customer.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            if (PlayerPrefs.GetString("potionRQ") == "BLUE")
            {
                Sucess();
            }
            else
            {
                Failure();
            }
        }
        else if (PlayerPrefs.GetString("reagentAdded") == "Purple")
        {
            customer.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            if (PlayerPrefs.GetString("potionRQ") == "GOLD")
            {
                Sucess();
            }
            else
            {
                Failure();
            }
        }
        else
        {
            Failure();
        }
    }

    public void Sucess()
    {
        customerText.text = "This is exactly what I wanted! Thank you!";
        playthroughs++;
        PlayerPrefs.GetInt("Playthroughs", playthroughs);
    }

    public void Failure()
    {
        customerText.text = "This is NOT what I wanted!!";
        playthroughs++;
        PlayerPrefs.GetInt("Playthroughs", playthroughs);
    }

    public void FloatSucess()
    {
        customerText.text = "I feel light! This is exactly what I wanted! Thank you!";
    }

    public void Continue()
    {
        if(PlayerPrefs.GetInt("Playthroughs") > 2)
        {
            SceneManager.LoadScene("DemoEndScene");
        }
        else
        {
            SceneManager.LoadScene("RequestScene");
        }
    }
}
