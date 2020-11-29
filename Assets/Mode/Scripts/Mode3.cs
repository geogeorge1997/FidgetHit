using UnityEngine;
using UnityEngine.UI;

public class Mode3 : MonoBehaviour
{
    public Text TextBox;
    private int setvalue = 100, locks, newvalue;

    void Start()
    {
        locks = PlayerPrefs.GetInt("M3lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
        }
    }

    public void M3()
    {
        locks = PlayerPrefs.GetInt("M3lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Modes", 3);
        }
        else
        {
            newvalue = PlayerPrefs.GetInt("GlobalCredits", 0);
            if (newvalue - setvalue >= 0)
            {
                newvalue = newvalue - setvalue;
                PlayerPrefs.SetInt("GlobalCredits", newvalue);
                PlayerPrefs.SetInt("M3lock", 1);
            }
        }

        locks = PlayerPrefs.GetInt("M3lock", 0);
        if (locks == 1)
        {
            TextBox.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Modes", 3);
            FindObjectOfType<BackGround>().news();
        }
    }

}