using UnityEngine;

public class BackGroundSound : MonoBehaviour {

    public AudioSource audioBackGround;
    public int Fidget = 1;

    void Start ()
    {
        Fidget = 0;
    }
	
	void Update ()
    {
        if (Fidget==0)
        {
            audioBackGround.gameObject.SetActive(false);
        }
	}

}