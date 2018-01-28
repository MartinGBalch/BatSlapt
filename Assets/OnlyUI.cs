using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnlyUI : MonoBehaviour
{
    public Text tip;
    public Text tip2;

    public Image win;

    public float timer = 5;
    public float timer2 = 5;

    bool hint = false;

    // Update is called once per frame

    void Start()
    {
        tip2.gameObject.SetActive(false);    
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
}
