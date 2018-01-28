using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{

    public Button start;
    public Button quit;
    public Button credits;

    public GameObject Credits;

    void Start()
    {
        Credits.gameObject.SetActive(false);    
    }

    public void startPress()
    {
        SceneManager.LoadScene("Beta");
        
    }

    public void quitPress()
    {
        Application.Quit();
    }

    public void creditClick()
    {
        Credits.gameObject.SetActive(true);
    }

    public void BackPress()
    {
        Credits.gameObject.SetActive(false);
    }
}
