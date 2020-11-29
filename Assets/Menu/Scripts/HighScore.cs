using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text HighScoreTextMenu;
    public int highScore;
    public int Score;

    // Use this for initialization
    void Start()
    {

        highScore=PlayerPrefs.GetInt("highScore", 0);
        Debug.Log("HighScore");
        Debug.Log(highScore);
        Score = PlayerPrefs.GetInt("CurrentScore", 0);
        if (Score > highScore)
        {
            highScore = Score;
            PlayerPrefs.SetInt("highScore", highScore);
        }
        HighScoreTextMenu.text = "High Score : " + highScore;

    }
}