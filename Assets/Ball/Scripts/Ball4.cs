using UnityEngine;
using UnityEngine.UI;

public class Ball4: MonoBehaviour
{
    public Text TextBox;
    private int setvalue = 300, locks, newvalue;

    void Start()
    {
        locks = PlayerPrefs.GetInt("B4lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
        }
    }

    public void B4()
    {
        locks = PlayerPrefs.GetInt("B4lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 4);
        }
        else
        {
            newvalue = PlayerPrefs.GetInt("GlobalCredits", 0);
            if (newvalue - setvalue >= 0)
            {
                newvalue = newvalue - setvalue;
                PlayerPrefs.SetInt("GlobalCredits", newvalue);
                PlayerPrefs.SetInt("B4lock", 1);
            }
        }

        locks = PlayerPrefs.GetInt("B4lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 4);
        }
    }
}