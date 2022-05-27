using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    public AudioSource audioSource;
    public AudioListener audioListener;

    public AudioClip scorePlusMusic;
    public AudioClip scoreDecreaseMusic;
    public AudioClip countdown;
    public Slider slider;   

    private void Awake()
    {
       // if (instance != null)
            instance = this;
    }

    public void ScorePlus()
    {
        audioSource.PlayOneShot(scorePlusMusic,1);
    }

    public void ScoreDeacrese()
    {
        audioSource.PlayOneShot(scoreDecreaseMusic, 1);
    }

    public void CountDown()
    {
        audioSource.PlayOneShot(countdown,0.5f);
        
    }

    public void SoundOff()
    {
        //audioSource.Stop();
        audioListener.enabled = false;
    }

    public void SoundOn()
    {
        audioListener.enabled = true;
        //audioSource.Play();
    }


    private void Update()
    {
        audioSource.volume = slider.value;
    }

    /* private void Update()
     {
         if(Input.GetMouseButtonDown(0))
         {
             ScorePlus();
         }
     }*/

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
