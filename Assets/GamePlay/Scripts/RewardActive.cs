using UnityEngine;

public class RewardActive : MonoBehaviour {//Reward Ads select Video

    public GameObject RewardsAds;

    public void ClickReward()
    {
        RewardsAds.gameObject.SetActive(true);
        FindObjectOfType<AboveAds>().Click();           
    }
}