using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    public int hp = 10;
    //public Text hpText;

    void Start()
    {
        //hpText.text = "HP: 3";
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("Oops!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            hp--;
            //hpText.text = "HP: " + hp;
            //same as hp -= or hp -1
            if(hp < 1)
            {
                //die
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                //SceneManager.LoadScene("HahaLoser");
            }
        }
        if(collision.gameObject.tag == "oneHit")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(collision.gameObject.tag == "LoadSceneTwo")
        {
            SceneManager.LoadScene("SceneTwo");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "enemyBullet")
        {
            hp--;
            //hpText.text = "HP: " + hp;
            if (hp < 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
