using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreCard : MonoBehaviour
{
    public Text scoreText,bonusText;
    public int i = 0;
    public int b;
    public GameObject bal;
    public int Bonus,realBonus,scoreIncCount=0;
    public int g=0,count,Score,Score2,valueCredits;

    public void ScoreInc()
    {
        realBonus = PlayerPrefs.GetInt("Bonus", 0);             //realBonus Get From Bonus , ball hit fidget continuesly
        realBonus = realBonus + 1;
        PlayerPrefs.SetInt("Bonus", realBonus);                 //Bonus Updated
        scoreIncCount= PlayerPrefs.GetInt("scoreInc", 0);       //scoreIncCount Get from scoreInc
        scoreIncCount = scoreIncCount + 1;
        if (realBonus > 1)
        {
            bonusText.text = "Bonus";
        }
        b = realBonus;
      
        i = i + b;
        PlayerPrefs.SetInt("ScoreRate", i);                     //Set ScoreRate as the real score
        PlayerPrefs.SetInt("scoreInc", scoreIncCount);          //Set scoreInc as scoreIncCount , number of times which ball hit the fidget
        Bonus = PlayerPrefs.GetInt("RewardBonus", 0);           //Get Bonus form RewardBonus

        if (Bonus > 0)
        {
            g = Bonus + i;
            scoreText.text = g.ToString();
        }
        else
        {
            g = i + 0;
            scoreText.text = g.ToString();
        }
    }

    public void OutCall()
    {
        PlayerPrefs.SetInt("ScoreRate", 0);             //Set ScoreRate to 0
        PlayerPrefs.SetInt("Bonus", 0);                 //Set Bonus to 0
        Bonus = PlayerPrefs.GetInt("RewardBonus", 0);   //Bonus = RewardBonus
        if (Bonus > 0)
        {
            g = Bonus + i;
            scoreText.text = g.ToString();
        }
        else
        {
            g = i + 0;
            scoreText.text = g.ToString();
        }
        scoreText.text = "Out";
        bal.SetActive(false);
        Invoke("SetGame", 1.0f);
    }

    public void SetGame()
    {
        PlayerPrefs.SetInt("CurrentScore",g);                       //Current Score 
        SceneManager.LoadScene("Menu");                                     
        PlayerPrefs.SetInt("RewardBonus", 0);                       //RewardBonus to 0
        count = PlayerPrefs.GetInt("Count", 0);                     //Get the mathces number
        count = count + 1;
        PlayerPrefs.SetInt("Count", count);                         //Update Count 
        Score2 = PlayerPrefs.GetInt("TotalScore", 0);               //Get TotalScore = Score2
        Score = PlayerPrefs.GetInt("CurrentScore", 0);              //Get Current Score = Score
        Score2 = Score2 + Score;
        PlayerPrefs.SetInt("TotalScore", Score2);                   //Set Score2 as ToatalScore
        Debug.Log("Total Score  Count");
        Debug.Log(Score2);
        Debug.Log(count);
        Score2 = Score2 / count;
        PlayerPrefs.SetInt("Average", Score2);                      //Set Average Score
        Debug.Log(Score2);
        Score = Score / 3;
        valueCredits = PlayerPrefs.GetInt("GlobalCredits", 0);      //Get Total Credits
        valueCredits = valueCredits + Score;
        PlayerPrefs.SetInt("GlobalCredits", valueCredits);          //Set Updated Total Credits
        PlayerPrefs.SetInt("scoreInc", 0);                          //Set ScoreInc to 0
    }

}