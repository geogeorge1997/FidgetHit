using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Order : MonoBehaviour {

    public Text Otext;
    public int i, SLimit,Lim;
    public string PG = "pg",a;
    public TouchScreenKeyboard keys;

	public void OrderBegin()
    {
        i = PlayerPrefs.GetInt("OI", 1);
        SLimit = PlayerPrefs.GetInt("PSLimit", 0);
        if (SLimit == 0)
        {
            Otext.text = "Enter Limit";
        }
        else
        {
            PG = PG + i;
            Invoke("OrderCall", 0);
        }                                                                       //PlayerPrefs Generated Beginig
	}
	
	public void OrderButton()
    {
        i = PlayerPrefs.GetInt("OI", 1);
        i = i + 1;
        PlayerPrefs.SetInt("OI", i);
        Invoke("OrderCall", 0);                                                 //PlayerPrefs Generating with i
    }

    void OrderCall()
    {
        SLimit = PlayerPrefs.GetInt("PSLimit", 0);
  
        if (i > SLimit)
        {
           Otext.text = "Finished ";
            SceneManager.LoadScene("Spin");
        }
        else
        {
            Otext.text = "Order " + i;
        }
    }

}