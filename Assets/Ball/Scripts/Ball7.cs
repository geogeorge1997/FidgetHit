using UnityEngine;
using UnityEngine.UI;

public class Ball7 : MonoBehaviour
{
    public Text TextBox;
    private int setvalue = 500, locks, newvalue;

    void Start()
    {
        locks = PlayerPrefs.GetInt("B7lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
        }
    }

    public void B7()
    {
        locks = PlayerPrefs.GetInt("B7lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 7);
        }
        else
        {
            newvalue = PlayerPrefs.GetInt("GlobalCredits", 0);
            if (newvalue - setvalue >= 0)
            {
                newvalue = newvalue - setvalue;
                PlayerPrefs.SetInt("GlobalCredits", newvalue);
                PlayerPrefs.SetInt("B7lock", 1);
            }
        }

        locks = PlayerPrefs.GetInt("B7lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Ball", 7);
        }
    }
}