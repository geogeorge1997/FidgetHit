using UnityEngine;

public class BackGroundSound2 : MonoBehaviour
{
    public AudioSource audioBackGround;
    public int Fidget = 1,lockSound;

    void Update()
    {
        audioBackGround = GetComponent<AudioSource>();
        Fidget = PlayerPrefs.GetInt("Sounds", 1);
        if (Fidget == 0)
        {
            audioBackGround.Stop();
            lockSound = 0;
            //audioBackGround.gameObject.SetActive(false);
        }
        else if(Fidget==1&&lockSound==0)
        {
            audioBackGround.Play();
            lockSound = 1;
           // audioBackGround.gameObject.SetActive(true);
        }
    }

}