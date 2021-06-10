using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EffectScript : MonoBehaviour
{
    int effectNumber;
    public Text flavorText;
    public GameObject addLeaf;
    public GameObject addBerry;
    public GameObject addSlime;
    public GameObject addStick;
    public GameObject addGreen;
    public GameObject addOrange;
    public GameObject addPurple;

    void Start()
    {
        addLeaf.gameObject.SetActive(false);
        addBerry.gameObject.SetActive(false);
        addSlime.gameObject.SetActive(false);
        addStick.gameObject.SetActive(false);
        addGreen.gameObject.SetActive(false);
        addOrange.gameObject.SetActive(false);
        addPurple.gameObject.SetActive(false);
        if(PlayerPrefs.GetString("potionRQ") == "RED" && PlayerPrefs.GetInt("acceptedQuest") == 1)
        {
            effectNumber = 1;
            PlayerPrefs.GetInt("effectValue", effectNumber);
        }
        else if(PlayerPrefs.GetString("potionRQ") == "BLUE" && PlayerPrefs.GetInt("acceptedQuest") == 1)
        {
            effectNumber = 2;
            PlayerPrefs.GetInt("effectValue", effectNumber);
        }
        else if (PlayerPrefs.GetString("potionRQ") == "GOLD" && PlayerPrefs.GetInt("acceptedQuest") == 1)
        {
            effectNumber = 3;
            PlayerPrefs.GetInt("effectValue", effectNumber);
        }
        else if (PlayerPrefs.GetString("potionRQ") == "BIG" && PlayerPrefs.GetInt("acceptedQuest") == 1)
        {
            effectNumber = 4;
            PlayerPrefs.GetInt("effectValue", effectNumber);
        }
        else if (PlayerPrefs.GetString("potionRQ") == "SMALL" && PlayerPrefs.GetInt("acceptedQuest") == 1)
        {
            effectNumber = 5;
            PlayerPrefs.GetInt("effectValue", effectNumber);
        }
        else if (PlayerPrefs.GetInt("acceptedQuest") == 1)
        {
            effectNumber = 6;
            PlayerPrefs.GetInt("effectValue", effectNumber);
        }
    }

    public void HighlightLeaf()
    {
        flavorText.text = "Parvus Leaf. It's very soft. Add it to your potion?";
        addLeaf.gameObject.SetActive(false);
        addBerry.gameObject.SetActive(false);
        addSlime.gameObject.SetActive(false);
        addStick.gameObject.SetActive(false);
        addGreen.gameObject.SetActive(false);
        addOrange.gameObject.SetActive(false);
        addPurple.gameObject.SetActive(false);
        addLeaf.gameObject.SetActive(true);
    }

    public void AddLeaf()
    {
        PlayerPrefs.GetString("reagentAdded", "Leaf");
    }

    public void HighlightBerry()
    {
        flavorText.text = "Magna Berry. It smells sweet. Add it to your potion?";
        addLeaf.gameObject.SetActive(false);
        addBerry.gameObject.SetActive(false);
        addSlime.gameObject.SetActive(false);
        addStick.gameObject.SetActive(false);
        addGreen.gameObject.SetActive(false);
        addOrange.gameObject.SetActive(false);
        addPurple.gameObject.SetActive(false);
        addBerry.gameObject.SetActive(true);
    }

    public void AddBerry()
    {
        PlayerPrefs.GetString("reagentAdded", "Berry");
    }

    public void HighlightSlime()
    {
        flavorText.text = "Volant Slime. It's sticky. Add it to your potion?";
        addLeaf.gameObject.SetActive(false);
        addBerry.gameObject.SetActive(false);
        addSlime.gameObject.SetActive(false);
        addStick.gameObject.SetActive(false);
        addGreen.gameObject.SetActive(false);
        addOrange.gameObject.SetActive(false);
        addPurple.gameObject.SetActive(false);
        addSlime.gameObject.SetActive(true);
    }

    public void AddSlime()
    {
        PlayerPrefs.GetString("reagentAdded", "Slime");
    }

    public void HighlightStick()
    {
        flavorText.text = "Initium Twig. It will reset your brew. Add it to your potion?";
        addLeaf.gameObject.SetActive(false);
        addBerry.gameObject.SetActive(false);
        addSlime.gameObject.SetActive(false);
        addStick.gameObject.SetActive(false);
        addGreen.gameObject.SetActive(false);
        addOrange.gameObject.SetActive(false);
        addPurple.gameObject.SetActive(false);
        addStick.gameObject.SetActive(true);
    }

    public void AddStick()
    {
        PlayerPrefs.GetString("reagentAdded", "");
    }

    public void HighlightGreen()
    {
        flavorText.text = "A viridi shell. It has a comforting shine. Add it to your potion?";
        addLeaf.gameObject.SetActive(false);
        addBerry.gameObject.SetActive(false);
        addSlime.gameObject.SetActive(false);
        addStick.gameObject.SetActive(false);
        addGreen.gameObject.SetActive(false);
        addOrange.gameObject.SetActive(false);
        addPurple.gameObject.SetActive(false);
        addGreen.gameObject.SetActive(true);
    }

    public void AddGreen()
    {
        PlayerPrefs.GetString("reagentAdded", "Green");
    }

    public void HighlightOrange()
    {
        flavorText.text = "An auran shell. It has a comforting shine. Add it to your potion?";
        addLeaf.gameObject.SetActive(false);
        addBerry.gameObject.SetActive(false);
        addSlime.gameObject.SetActive(false);
        addStick.gameObject.SetActive(false);
        addGreen.gameObject.SetActive(false);
        addOrange.gameObject.SetActive(false);
        addPurple.gameObject.SetActive(false);
        addOrange.gameObject.SetActive(true);
    }

    public void AddOrange()
    {
        PlayerPrefs.GetString("reagentAdded", "Orange");
    }

    public void HighlightPurple()
    {
        flavorText.text = "A purpura shell. It has a comforting shine. Add it to your potion?";
        addLeaf.gameObject.SetActive(false);
        addBerry.gameObject.SetActive(false);
        addSlime.gameObject.SetActive(false);
        addStick.gameObject.SetActive(false);
        addGreen.gameObject.SetActive(false);
        addOrange.gameObject.SetActive(false);
        addPurple.gameObject.SetActive(true);
    }

    public void AddPurple()
    {
        PlayerPrefs.GetString("reagentAdded", "Purple");
    }

    public void FinishPotion()
    {
        SceneManager.LoadScene("CustomerScene");
    }
}
