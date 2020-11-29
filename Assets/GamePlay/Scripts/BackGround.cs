using UnityEngine;

public class BackGround : MonoBehaviour {

    public int ModeDisplay;

    void Start()
    { 
        transform.localScale = new Vector3(Screen.width / 19.25f, Screen.height / 10.8f, Screen.height / 1000.0f);
        transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 0.0f);
        ModeDisplay=PlayerPrefs.GetInt("Modes", 1);
    }

    void Update()
    {
        if (ModeDisplay == 1)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else if (ModeDisplay == 2)
        {
            GetComponent<Renderer>().material.color = new Color(.59f, .59f, .59f);
        }
        else if (ModeDisplay == 3)
        {
            GetComponent<Renderer>().material.color = new Color(0.0f, .655f, 1.0f);
        }
    }
    public void news()
    {
        ModeDisplay = PlayerPrefs.GetInt("Modes", 1);
        Update();
    }

}