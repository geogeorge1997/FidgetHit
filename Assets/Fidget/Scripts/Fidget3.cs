using UnityEngine;
using UnityEngine.UI;

public class Fidget3 : MonoBehaviour
{
    public Text TextBox;
    private int setvalue = 200, locks, newvalue;

    void Start()
    {
        locks = PlayerPrefs.GetInt("F3lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
        }
    }

    public void F3()
    {
        locks = PlayerPrefs.GetInt("F3lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Fidget", 3);
        }
        else
        {
            newvalue = PlayerPrefs.GetInt("GlobalCredits", 0);
            if (newvalue - setvalue >= 0)
            {
                newvalue = newvalue - setvalue;
                PlayerPrefs.SetInt("GlobalCredits", newvalue);
                PlayerPrefs.SetInt("F3lock", 1);
            }
        }

        locks = PlayerPrefs.GetInt("F3lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Fidget", 3);
        }
    }
}