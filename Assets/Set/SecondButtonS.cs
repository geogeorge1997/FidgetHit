using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class SecondButtonS : MonoBehaviour {

    public Text  Stext;
    private int i, SLimit, Lims,gval;
    private string PG = "pg", ass;
    private TouchScreenKeyboard keys;

    void Start()
    {
        Lims = 0;
        Stext.text = Lims.ToString();
    }

    public void SecondButton()
    {
        PlayerPrefs.SetInt("gvals", 2);
        gval = PlayerPrefs.GetInt("gvals", 5);
        keys = TouchScreenKeyboard.Open(ass, TouchScreenKeyboardType.NumberPad);      
    }

    void Update()
    {
        gval = PlayerPrefs.GetInt("gvals", 5);
        if (gval == 2)
        {
            PG = "pg";
            i = PlayerPrefs.GetInt("OI", 1);
            PG = PG + i;
            PG = PG + "s";                                                          //SecondsButton Setting PlayerPrefs

            if (!keys.active)
            {
                ass = keys.text;
                Lims = System.Int32.Parse(ass);
                Stext.text = ass;
                if (Lims > 3)
                {
                    Lims = 3;
                    Stext.text = "3";
                }
                PlayerPrefs.SetInt(PG, Lims);
            }
            PlayerPrefs.SetInt(PG, Lims);
            PG = "pg";                                                               //Reseting PlayerPrefs
            PG = PG + i;
        }
    }

}