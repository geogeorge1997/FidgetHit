using UnityEngine;
using UnityEngine.UI;

public class CreditInfo : MonoBehaviour//Rewarded Video Problem is solved 
{
  public int globalCreditValue,creditReward,valueCredited,locks;
    public Text creditText;

    // Use this for initialization
    void Start()
    {
        globalCreditValue = PlayerPrefs.GetInt("GlobalCredits", 0);
        creditText.text =  globalCreditValue.ToString();
    }

    void Update()
    {
        locks = PlayerPrefs.GetInt("lock", 0);
        if (locks==1)
        {
            creditReward = 100;
            valueCredited = PlayerPrefs.GetInt("GlobalCredits", 0);
            valueCredited = valueCredited + creditReward;
            PlayerPrefs.SetInt("GlobalCredits", valueCredited);
            PlayerPrefs.SetInt("lock", 0);
        }
        globalCreditValue = PlayerPrefs.GetInt("GlobalCredits", 0);
        creditText.text = "Total Credits : "+globalCreditValue;
    }
}