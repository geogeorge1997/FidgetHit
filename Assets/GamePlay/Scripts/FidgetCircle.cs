using UnityEngine;
using UnityEngine.UI;

public class FidgetCircle : MonoBehaviour
{
    public AudioClip audioClipOut;
    public AudioSource audioSourceOut;
    public int FidgetOut = 1,count,AdNumP;
    public Button Buten,Buten2;
    public GameObject Balls;

    void Start()
    {
        FidgetOut = PlayerPrefs.GetInt("Sounds", 1);
        audioSourceOut.clip = audioClipOut;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (FidgetOut == 1)
        {
            audioSourceOut.Play();
        }

        else
        {
            audioSourceOut.Stop();
        }

        count = PlayerPrefs.GetInt("CountAds", 0);      //CountAds form Ads 

        if(Application.internetReachability == NetworkReachability.NotReachable)//Internet Checking
        {
            PlayerPrefs.SetInt("CountAds", 0);
            FindObjectOfType<ScoreCard>().OutCall();
        }

        else
        {
            Invoke("AdsInit", 0.14f);     
        }
    }

    public void AdsInit()
    {
        AdNumP = PlayerPrefs.GetInt("AdLoad", 0);
        if (count == 0&&AdNumP==1)
        {
            Buten.gameObject.SetActive(true);
            Buten2.gameObject.SetActive(true);
            Balls.gameObject.SetActive(false);
        }
        else
        {
            PlayerPrefs.SetInt("CountAds", 0);
            FindObjectOfType<ScoreCard>().OutCall();
        }
    }

}