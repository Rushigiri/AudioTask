using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum basketType
{
    Food,
    Accessory,
    Trekking


}
public class BasketManager : MonoBehaviour
{
   // public itemModel itemModel;
    public basketType basketType;
    public Text basketScoreTxt;
    //public AudioManager audio;
    public int basketScore;


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
     
    //   /* if ((int)itemModel.type == (int)basketType)
    //    {
    //        ScoreManager.instances.score++;
    //    }*/
    //}
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log(itemModel.type.ToString());
     
        if ((collision.gameObject.GetComponent<itemModel>().type.ToString() == basketType.ToString()))
        {
            
                collision.gameObject.SetActive(false);
            ScoreManager.instances.totalScore  +=5;
            ScoreManager.instances.totalScore2  += 5;
            basketScore += 5;
            ScoreManager.instances.totalScoreTxt.text = ScoreManager.instances.totalScore.ToString();
            ScoreManager.instances.totalScoteTxt2.text = ScoreManager.instances.totalScore2.ToString();
            AudioManager.instance.ScorePlus();

            basketScoreTxt.text = basketScore.ToString();
            //ScoreManager.instances.score++;

         /*   if (basketType.ToString() == "Food")
            {
                Debug.Log("increase food score");
                ScoreManager.instances.foodScore+=5;
                ScoreManager.instances.totalScore+=5;
                ScoreManager.instances.totalScore2 += 5;

            }
            else if ((basketType.ToString() == "Accessory"))
            {
                ScoreManager.instances.accesoriesScore+=5;
                Debug.Log("increase accessories score");
                ScoreManager.instances.totalScore+=5;
                ScoreManager.instances.totalScore2 += 5;


            }

            else if ((basketType.ToString() == "Trekking"))
            {
                ScoreManager.instances.trekkingScore+=5;
                Debug.Log("Increse treking score");
                ScoreManager.instances.totalScore+=5;
                ScoreManager.instances.totalScore2 += 5;

            }*/
          

        }
        else
        {
            ScoreManager.instances.totalScore -= 5;
            ScoreManager.instances.totalScore2 -= 5;
            ScoreManager.instances.dustbinScore++;
            ScoreManager.instances.totalScoreTxt.text = ScoreManager.instances.totalScore.ToString();
            ScoreManager.instances.totalScoteTxt2.text = ScoreManager.instances.totalScore.ToString();
            ScoreManager.instances.dustbinScoreTxt.text = ScoreManager.instances.dustbinScore.ToString();
            collision.gameObject.SetActive(false);
            AudioManager.instance.ScoreDeacrese();


        }
        {
           
        }
    }

    //// Start is called before the first frame update
    void Start()
    {
        basketScore = 0;
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
