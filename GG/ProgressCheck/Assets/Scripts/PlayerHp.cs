using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
    public int hp = 10;
    public Text health;
    public Slider healthSlider;
    public int lives;

    void Start()
    {
        health.text = "Health: " + hp;
        healthSlider.maxValue = hp;
        healthSlider.value = hp;
        lives = PlayerPrefs.GetInt("Lives");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("Oops!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            health.text = "Health: " + hp;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            hp--;
            health.text = "Health: " + hp;
            healthSlider.value = hp;
            //same as hp -= or hp -1
            if (hp < 1)
            {
                if(lives > 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    PlayerPrefs.SetInt("Lives", lives - 1);
                }
                else
                {
                    //die
                    SceneManager.LoadScene(2);
                }
            }
        }
        if(hp ==1)
        {
            health.text = "uh oh spaghettios";
            //play megalovania
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gate")
        {
            SceneManager.LoadScene(1);
        }
    }
}
