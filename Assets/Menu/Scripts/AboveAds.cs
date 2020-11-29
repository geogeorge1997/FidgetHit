using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class AboveAds : MonoBehaviour
{
    public RewardBasedVideoAd rewardBasedVideo1;
    public int valueReward,vS,vL,vLU;

    public void Start()
    {
        string appId = "ca-app-pub-6338977167328988~3985994970";

        MobileAds.Initialize(appId);
        
        // Get singleton reward based video ad reference.
        this.rewardBasedVideo1 = RewardBasedVideoAd.Instance;

        // RewardBasedVideoAd is a singleton, so handlers should only be registered once.
        //  this.rewardBasedVideo.OnAdLoaded += this.HandleRewardBasedVideoLoaded;
        //  this.rewardBasedVideo.OnAdFailedToLoad += this.HandleRewardBasedVideoFailedToLoad;
        //  this.rewardBasedVideo.OnAdOpening += this.HandleRewardBasedVideoOpened;
        //  this.rewardBasedVideo.OnAdStarted += this.HandleRewardBasedVideoStarted;
          this.rewardBasedVideo1.OnAdRewarded += this.HandleRewardBasedVideoRewarded;
       //   this.rewardBasedVideo.OnAdClosed += this.HandleRewardBasedVideoClosed;
       //   this.rewardBasedVideo.OnAdLeavingApplication += this.HandleRewardBasedVideoLeftApplication;
      
        Invoke("Reward", 0.0f);
    }
    void Update()
    {
        if (vS != 1 && vL == 1 && vLU == 0)
        {
            this.RequestRewardBasedVideo();
            vLU = 1;
        }
    }
    public void Reward()
    {
        this.RequestRewardBasedVideo();
    }
    public void Click()
    {
        this.rewardBasedVideo1.Show();
        vLU = 0;
        vS = 0;
        PlayerPrefs.SetInt("AdLoad", 0);
    }

    // Returns an ad request with custom ad targeting.
    private AdRequest CreateAdRequest()
    {
        return new AdRequest.Builder().Build();
    }

    private void RequestRewardBasedVideo()
    {
        string adUnitId = "ca-app-pub-6338977167328988/9020807539";
        this.rewardBasedVideo1.LoadAd(this.CreateAdRequest(), adUnitId);
        this.ShowRewardBasedVideo();
    }

    private void ShowRewardBasedVideo()
    {
        if (this.rewardBasedVideo1.IsLoaded())
        {
            vL = 1;
            PlayerPrefs.SetInt("AdLoad", 1);
            Debug.Log("Success");
        }
        else
        {
            MonoBehaviour.print("Reward based video ad is not ready yet");
        }
    }

    public void HandleRewardBasedVideoRewarded(object sender, Reward args)
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 1)
        {
            vS = 1;
            PlayerPrefs.SetInt("CountAds", 1);
            valueReward = PlayerPrefs.GetInt("ScoreRate", 0);
            PlayerPrefs.SetInt("RewardBonus", valueReward);
            SceneManager.LoadScene("GamePlay");
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