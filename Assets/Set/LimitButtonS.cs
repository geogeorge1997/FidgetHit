using UnityEngine;
using UnityEngine.UI;

public class LimitButtonS : MonoBehaviour
{
    public TouchScreenKeyboard key1;
    public Text Ltext, Otext;
    public string a="";
    public int b, g,gval;
    public Button SaveButtons,BackButtons;
    private int setvalue = 50, newvalue;

    public void Sta()
    {
        newvalue = PlayerPrefs.GetInt("GlobalCredits", 0);
        if (newvalue - setvalue >= 0)
        {
            newvalue = newvalue - setvalue;
            PlayerPrefs.SetInt("GlobalCredits", newvalue);
            PlayerPrefs.SetInt("OI", 1);
            PlayerPrefs.SetInt("gvals", 1);
            gval = PlayerPrefs.GetInt("gvals", 5);
            key1 = TouchScreenKeyboard.Open(a, TouchScreenKeyboardType.NumberPad);
        }
        else
        {
            BackButtons.gameObject.SetActive(true);
        }
    }

    void Update()
    {
        gval = PlayerPrefs.GetInt("gvals", 5);
        if (gval == 1)
        {

            a = key1.text;
            Ltext.text = a;
            b = System.Int32.Parse(a);
            if (b >= 10)
            {
                b = 10;
                a = "10";
                Ltext.text = a;
            }

            if (!key1.active && g == 1)
            {
                PlayerPrefs.SetInt("PSLimit", b);           //StructureLimit ,calculation of structure limit shown above
                g = 0;
                FindObjectOfType<Order>().OrderBegin();
                SaveButtons.gameObject.SetActive(true);
            }
            if (key1.active)
            {
                g = 1;
                SaveButtons.gameObject.SetActive(false);
            }
        }
    }

}