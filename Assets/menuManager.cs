using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{

    public Button start;
    public Button quit;

    public void startPress()
    {
        SceneManager.LoadScene("Beta");
    }

    public void quitPress()
    {
        Application.Quit();
    }
}
