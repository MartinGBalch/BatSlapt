using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    public int Health;
    public bool IsDark;
    public bool IsAlive = true;
    public bool Win = false;

    public AudioClip ClipOof;
    public AudioClip ClipYeahBoi;
    public AudioClip ClipBummer;

    private AudioSource AudioOof;
    private AudioSource AudioYeahBoi;
    private AudioSource AudioBummer;

    public GameObject win;

    void Start() {win.gameObject.SetActive(false);}

    public AudioSource AddAudio(AudioClip clip, bool loop, bool playAwake, float vol)
    {
        AudioSource newAudio = gameObject.AddComponent<AudioSource>();
        newAudio.clip = clip; 
        newAudio.loop = loop;
        newAudio.playOnAwake = playAwake;
        newAudio.volume = vol; 
        return newAudio;
    }

    public void Awake()
    {
        // add the necessary AudioSources:
        AudioOof = AddAudio(ClipOof, false, false, .8f);
        AudioYeahBoi = AddAudio(ClipYeahBoi, false, false, 1f);
        AudioBummer = AddAudio(ClipBummer, false, false, .8f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0 && IsAlive)
        {
            AudioBummer.Play();
            transform.position = new Vector3(-666, -666, -666);
            IsAlive = false;
        }

        if (Win == true)
        {
            PlayerWin();
        }

        RenderSettings.fog = IsDark;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Health--;
            AudioOof.Play();
            //StartCoroutine("Flasher");
        }
        if (other.gameObject.tag == "Goal")
        {
            Win = true;
            PlayerWin();
            AudioYeahBoi.Play();
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
           
        }
    }
    void PlayerWin()
    {
       win.gameObject.SetActive(true);
    }
}


