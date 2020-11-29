using UnityEngine;
using UnityEngine.UI;

public class ScoreCardMenu : MonoBehaviour
{
    public int Score;
    public Text ScoreTextMenu;

    void Start()
    {
        Score= PlayerPrefs.GetInt("CurrentScore", 0);
        ScoreTextMenu.text = "Previous Score : " + Score;
    }
}