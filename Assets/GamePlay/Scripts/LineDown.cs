using UnityEngine;
using UnityEngine.UI;

public class LineDown : MonoBehaviour {

    public Text bonusText;

	void Start () {

        transform.localScale = new Vector3(Screen.width*2.89f, 1.0f, 1.0f);
        transform.position = new Vector3(Screen.width/2, Screen.height/4.0f, 0.0f);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        bonusText.text = "";
        PlayerPrefs.SetInt("Bonus", 0);
    }
}