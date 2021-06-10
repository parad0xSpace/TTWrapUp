using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPTracker : MonoBehaviour
{
    int xp;
    string title;
    public Text xpTitle;
    public Slider xpValue;

    void Start()
    {
        if (PlayerPrefs.GetInt("xp") != 0)
        {
            xp = PlayerPrefs.GetInt("xp");
        }
        
    }

    void ResultLvlUp()
    {
        //if result == success
            //xp += 10 * effects
            //xp value = xp
    }

    void LevelUp()
    {

    }
}
