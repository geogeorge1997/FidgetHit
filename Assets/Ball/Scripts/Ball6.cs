using UnityEngine;
using UnityEngine.UI;

public class Ball6 : MonoBehaviour
{
    public Text TextBox;
    private int setvalue = 500, locks, newvalue;

    void Start()
    {
        locks = PlayerPrefs.GetInt("B6lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
        }
    }

    public void B6()
    {
        locks = PlayerPrefs.GetInt("B6lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 6);
        }
        else
        {
            newvalue = PlayerPrefs.GetInt("GlobalCredits", 0);
            if (newvalue - setvalue >= 0)
            {
                newvalue = newvalue - setvalue;
                PlayerPrefs.SetInt("GlobalCredits", newvalue);
                PlayerPrefs.SetInt("B6lock", 1);
            }
        }

        locks = PlayerPrefs.GetInt("B6lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 6);
        }
    }
}