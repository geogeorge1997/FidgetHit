using UnityEngine;

public class BackGroundMini : MonoBehaviour {

    public int ModDisplay; 

	void Start ()
    {
        transform.localScale = new Vector3(Screen.width / 19.25f, Screen.height / 43.4f, Screen.height / 1000.0f);
        transform.position = new Vector3(Screen.width / 2, Screen.height / 8.0f, 0.0f);
        ModDisplay = PlayerPrefs.GetInt("Modes", 1);
    }
	
	void Update () {

        if (ModDisplay == 1)
        {
            GetComponent<Renderer>().material.color = new Color(.9f,.9f,.9f);
        }
        else if (ModDisplay == 2)
        {
            GetComponent<Renderer>().material.color = new Color(.49f, .49f, .49f);
        }
        else if (ModDisplay == 3)
        {
            GetComponent<Renderer>().material.color = new Color(0.0f, .554f,.9f);
        }
    }

}