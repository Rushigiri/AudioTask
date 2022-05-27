using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum scoreType
{
    foodScore,
    accessoriesScore,
    trekkingScore
}



public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instances;

    public Text totalScoreTxt;
    public Text dustbinScoreTxt;
    public Text timerTxt;
    public Text totalScoteTxt2;
    public int foodScore = 0;
    public int accesoriesScore = 0;
    public int trekkingScore = 0;
    public int dustbinScore = 0;
    public int totalScore = 0;
    public int totalScore2 = 0;
    public float timer;
    public scoreType scoreType;
    public GameObject mainCanvas;
    public GameObject gameoverCanvas;
    public GameObject soundCanvas;


    // Start is called before the first frame update
    void Start()
    {
      
        instances = this;
        AudioManager.instance.CountDown();


    }

    public void SoundSetting()
    {
        mainCanvas.gameObject.SetActive(false);
        soundCanvas.gameObject.SetActive(true);
    }

    public void Back()
    {
        soundCanvas.gameObject.SetActive(false);
        mainCanvas.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {


        if (timer > 0.2f)
        {
            timer -= Time.deltaTime;
            timerTxt.text = Mathf.Floor(timer).ToString();

        }
        if (timer < 10)
        {
            
            timerTxt.color = Color.red;
        
  
        }
        if (timer < 0.2f)
        {
            mainCanvas.GetComponent<Canvas>().enabled = false;
            gameoverCanvas.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
            AudioManager.instance.audioSource.Pause();
            
        }



    }


}
