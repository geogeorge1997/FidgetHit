using UnityEngine;
using UnityEngine.UI;

public class Fidget4 : MonoBehaviour
{
    public Text TextBox;
    private int setvalue = 300, locks, newvalue;

    void Start()
    {
        locks = PlayerPrefs.GetInt("F4lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
        }
    }

    public void F4()
    {
        locks = PlayerPrefs.GetInt("F4lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Fidget", 4);
        }
        else
        {
            newvalue = PlayerPrefs.GetInt("GlobalCredits", 0);
            if (newvalue - setvalue >= 0)
            {
                newvalue = newvalue - setvalue;
                PlayerPrefs.SetInt("GlobalCredits", newvalue);
                PlayerPrefs.SetInt("F4lock", 1);
            }
        }

        locks = PlayerPrefs.GetInt("F4lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Fidget", 4);
        }
    }
}