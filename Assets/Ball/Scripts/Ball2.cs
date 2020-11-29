using UnityEngine;
using UnityEngine.UI;

public class Ball2 : MonoBehaviour
{
    public Text TextBox;
    private int setvalue = 100, locks, newvalue;

    void Start()
    {
        locks = PlayerPrefs.GetInt("B2lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
        }
    }

    public void B2()
    {
        locks = PlayerPrefs.GetInt("B2lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 2);
        }
        else
        {
            newvalue = PlayerPrefs.GetInt("GlobalCredits", 0);
            if (newvalue - setvalue >= 0)
            {
                newvalue = newvalue - setvalue;
                PlayerPrefs.SetInt("GlobalCredits", newvalue);
                PlayerPrefs.SetInt("B2lock", 1);
            }
        }

        locks = PlayerPrefs.GetInt("B2lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 2);
        }
    }
}