using UnityEngine;
using UnityEngine.UI;

public class Ball5 : MonoBehaviour
{
    public Text TextBox;
    private int setvalue = 400, locks, newvalue;

    void Start()
    {
        locks = PlayerPrefs.GetInt("B5lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
        }
    }

    public void B5()
    {
        locks = PlayerPrefs.GetInt("B5lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 5);
        }
        else
        {
            newvalue = PlayerPrefs.GetInt("GlobalCredits", 0);
            if (newvalue - setvalue >= 0)
            {
                newvalue = newvalue - setvalue;
                PlayerPrefs.SetInt("GlobalCredits", newvalue);
                PlayerPrefs.SetInt("B5lock", 1);
            }
        }

        locks = PlayerPrefs.GetInt("B5lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 5);
        }
    }
}