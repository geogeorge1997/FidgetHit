using UnityEngine;
using UnityEngine.UI;

public class LineLeft : MonoBehaviour {

    public Text bonusText;

	void Start () {

        transform.localScale = new Vector3(5.0f, Screen.height/10, 5.0f);
        transform.position = new Vector3(0.0f, Screen.height / 2, 0.0f);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        bonusText.text = "";
        PlayerPrefs.SetInt("Bonus", 0);
    }
}