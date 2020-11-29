using UnityEngine.UI;
using UnityEngine;

public class LeftButtonS : MonoBehaviour {

    public Text Ltext;
    private int i, SLimit, Liml,gval;
    private string PG = "pg", al;
    private TouchScreenKeyboard keyl;

    void Start()
    {
        Liml = 0;
        Ltext.text = Liml.ToString();
    }

    public void LeftButton()
    {      
        PlayerPrefs.SetInt("gvals", 4);
        gval = PlayerPrefs.GetInt("gvals", 5);      
        keyl = TouchScreenKeyboard.Open(al, TouchScreenKeyboardType.NumberPad);       
    }

    void Update()
    {
        gval = PlayerPrefs.GetInt("gvals", 5);
        if (gval == 4)
        {
            PG = "pg";
            i = PlayerPrefs.GetInt("OI", 1);
            PG = PG + i;
            PG = PG + "l";                                                          //RotationLeftButton Setting PlayerPrefs

            if (!keyl.active)
            {
                al = keyl.text;
                Liml = System.Int32.Parse(al);
                Ltext.text = al;
                if (Liml > 179)
                {
                    Liml = 179;
                    Ltext.text = "179";
                }
                PlayerPrefs.SetInt(PG, Liml);
            }
            PlayerPrefs.SetInt(PG, Liml);
            PG = "pg";                                                              //Reseting PlayerPrefs
            PG = PG + i;
        }
    }

}