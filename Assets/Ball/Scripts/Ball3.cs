using UnityEngine;
using UnityEngine.UI;

public class Ball3 : MonoBehaviour
{
    public Text TextBox;
    private int setvalue = 200, locks, newvalue;

    void Start()
    {
        locks = PlayerPrefs.GetInt("B3lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
        }
    }

    public void B3()
    {
        locks = PlayerPrefs.GetInt("B3lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 3);
        }
        else
        {
            newvalue = PlayerPrefs.GetInt("GlobalCredits", 0);
            if (newvalue - setvalue >= 0)
            {
                newvalue = newvalue - setvalue;
                PlayerPrefs.SetInt("GlobalCredits", newvalue);
                PlayerPrefs.SetInt("B3lock", 1);
            }
        }

        locks = PlayerPrefs.GetInt("B3lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 3);
        }
    }
}