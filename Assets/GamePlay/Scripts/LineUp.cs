using UnityEngine;
using UnityEngine.UI;

public class LineUp : MonoBehaviour {

    public Text bonusText;

	void Start () {

        transform.localScale = new Vector3(Screen.width*2.89f, 1.0f, 1.0f);
        transform.position = new Vector3(Screen.width / 2, Screen.height, 0.0f);
    }

}