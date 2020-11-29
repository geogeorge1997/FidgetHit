using UnityEngine;
using UnityEngine.UI;

public class FidgetMove : MonoBehaviour
{
    float screenWidth = Screen.width;

    float angleT;
    float Neg;

    public AudioClip audioClip;
    public AudioSource audioSource;

    public int Fidget = 1;
    public int vibrations;

    public Button ButEn,ButEn2;

    void Start()
    {
        ButEn.gameObject.SetActive(false);
        ButEn2.gameObject.SetActive(false);
        transform.localScale = new Vector3(Screen.width / 7.39f, Screen.width / 7.39f, Screen.width / 100.0f);
        transform.position = new Vector3(Screen.width / 2, ((Screen.height / 10) + (Screen.height / 7.5f)), 0.0f);

        Fidget = PlayerPrefs.GetInt("Sounds", 1);
        audioSource.clip = audioClip;
    }

    void Update()
    {/*
        Touch touch = Input.GetTouch(0);
        if (touch.position.y >= ((Screen.height / 10) + (Screen.height / 7.5f)) - 1)
        {
            angleT1 = (touch.deltaPosition.x * 208.0f) / screenWidth;
            Neg1 = -angleT1;
            transform.Rotate(0, 0, Neg1);
        }
        else
        {
            angleT1 = (touch.deltaPosition.x * 208.0f) / screenWidth;
            Neg1 = angleT1;
            transform.Rotate(0, 0, Neg1);
        }

        if (touch.position.x >= (Screen.width / 2) - 1)
        {
            angleT1 = (touch.deltaPosition.y * 208.0f) / Screen.height;
            Neg1 = angleT1;
            transform.Rotate(0, 0, Neg1);
        }
        else
        {
            angleT1 = (touch.deltaPosition.y * 208.0f) / Screen.height;
            Neg1 = -angleT1;
            transform.Rotate(0, 0, Neg1);
        }
        */
        Touch touch = Input.GetTouch(0);
        angleT = (touch.deltaPosition.x*360.0f )/screenWidth;
        Neg = -angleT;
        transform.Rotate(0, 0, Neg);
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<ScoreCard>().ScoreInc();
        FindObjectOfType<BallMove>().BallPos();

        if (Fidget == 1)
        {
            audioSource.Play();      
        }
        else
        {
            audioSource.Stop();
        }

        vibrations = PlayerPrefs.GetInt("Vibration", 1);
        if (vibrations == 1)
        {
            Handheld.Vibrate();
        }
    }
}