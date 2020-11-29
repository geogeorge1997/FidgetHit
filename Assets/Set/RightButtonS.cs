using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class RightButtonS : MonoBehaviour {

    public Text Rtext;
    private int i, SLimit, Limr,gval;
    private string PG = "pg", ar;
    private TouchScreenKeyboard keyr;

    void Start()
    {
        Limr = 0;
        Rtext.text = Limr.ToString();
    }

    public void RightButton()
    {    
        PlayerPrefs.SetInt("gvals", 3);
        gval = PlayerPrefs.GetInt("gvals", 5);
        keyr = TouchScreenKeyboard.Open(ar, TouchScreenKeyboardType.NumberPad);
    }

    void Update()
    {
        gval = PlayerPrefs.GetInt("gvals", 5);
        if (gval == 3)
        {
            PG = "pg";
            i = PlayerPrefs.GetInt("OI", 1);
            PG = PG + i;
            PG = PG + "r";                                                          //RotationRightButton Setting PlayerPrefs

            if (!keyr.active)
            {
                ar = keyr.text;
                Limr = System.Int32.Parse(ar);
                Rtext.text = ar;
                if (Limr > 179)
                {
                    Limr = 179;
                    Rtext.text = "179";
                }
                PlayerPrefs.SetInt(PG, Limr);
            }
            PlayerPrefs.SetInt(PG, Limr);
            PG = "pg";                                                               //Reseting PlayerPrefs
            PG = PG + i;
        }
    }

}