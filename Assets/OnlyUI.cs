using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnlyUI : MonoBehaviour
{
    public Text tip;
    public Text tip2;

    
    public GameObject lose;
    public float timer = 5;
    public float timer2 = 5;

    Player player;

    bool hint = false;

    // Update is called once per frame

    void Start()
    {
        tip2.gameObject.SetActive(false);
       
        lose.gameObject.SetActive(false);
    }
    void Update ()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            tip.gameObject.SetActive(false);
            hint = true;
        }
        if (hint == true)
        {
            timer2 -= Time.deltaTime;
            tip2.gameObject.SetActive(true);
        }
        if (timer2 <= 0)
        {
            tip2.gameObject.SetActive(false);
        }

        
	}

    

    void PlayerLose()
    {
        if(player.IsAlive == false)
        {
            lose.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        lose.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Beta");
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
