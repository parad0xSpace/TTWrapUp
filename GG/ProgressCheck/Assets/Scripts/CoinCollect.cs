using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public int wallet = 0;
    public Text walletText;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            wallet++;
            walletText.text = "Diamonds: " + wallet;
            Destroy(collision.gameObject);
        }
    }
}
