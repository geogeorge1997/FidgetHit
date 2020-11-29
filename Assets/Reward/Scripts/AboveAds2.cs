using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AboveAds2 : MonoBehaviour
{
    private RewardBasedVideoAd rewardBasedVideo2;
    public Text text100;

    void Start()
    {
        
        string appId = "ca-app-pub-6338977167328988~3985994970";

        MobileAds.Initialize(appId);
        
        // Get singleton reward based video ad reference.
        this.rewardBasedVideo2 = RewardBasedVideoAd.Instance;

        // RewardBasedVideoAd is a singleton, so handlers should only be registered once.
        //  this.rewardBasedVideo.OnAdLoaded += this.HandleRewardBasedVideoLoaded;
        //  this.rewardBasedVideo.OnAdFailedToLoad += this.HandleRewardBasedVideoFailedToLoad;
        //  this.rewardBasedVideo.OnAdOpening += this.HandleRewardBasedVideoOpened;
        //  this.rewardBasedVideo.OnAdStarted += this.HandleRewardBasedVideoStarted;
        this.rewardBasedVideo2.OnAdRewarded += this.HandleRewardBasedVideoRewarded;
        //   this.rewardBasedVideo.OnAdClosed += this.HandleRewardBasedVideoClosed;
        //   this.rewardBasedVideo.OnAdLeavingApplication += this.HandleRewardBasedVideoLeftApplication;

        Invoke("Reward", 0.0f);
    }

    public void Reward()
    {
        this.RequestRewardBasedVideo();
    }
    public void ClickReward1()
    {
        this.rewardBasedVideo2.Show();
    }

    // Returns an ad request with custom ad targeting.
    private AdRequest CreateAdRequest()
    {
        return new AdRequest.Builder().Build();
    }



    private void RequestRewardBasedVideo()
    {
        string adUnitId = "ca-app-pub-6338977167328988/9020807539";
        this.rewardBasedVideo2.LoadAd(this.CreateAdRequest(), adUnitId);
        this.ShowRewardBasedVideo();
    }

    private void ShowRewardBasedVideo()
    {
        if (this.rewardBasedVideo2.IsLoaded())
        {
            text100.gameObject.SetActive(true);
            Debug.Log("Set Value here");
        }
        else
        {
            MonoBehaviour.print("Reward based video ad is not ready yet");
        }
    }


    public void HandleRewardBasedVideoRewarded(object sender, Reward args)
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 5)
        {
            PlayerPrefs.SetInt("lock", 1);
        }
    }

    /*  #region RewardBasedVideo callback handlers

      public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
      {
          MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");
      }

      public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
      {
          MonoBehaviour.print(
              "HandleRewardBasedVideoFailedToLoad event received with message: " + args.Message);
      }

      public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
      {
          MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
      }

      public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
      {
          MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
      }

      public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
      {
          MonoBehaviour.print("HandleRewardBasedVideoClosed event received");
      }

      public void HandleRewardBasedVideoRewarded(object sender, Reward args)
      {
          string type = args.Type;
          double amount = args.Amount;
          MonoBehaviour.print(
              "HandleRewardBasedVideoRewarded event received for " + amount.ToString() + " " + type);
      }

      public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
      {
          MonoBehaviour.print("HandleRewardBasedVideoLeftApplication event received");
      }

      #endregion*/

}