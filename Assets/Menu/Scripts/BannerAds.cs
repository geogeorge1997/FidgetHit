using GoogleMobileAds.Api;
using UnityEngine;

public class BannerAds : MonoBehaviour
{
    public BannerView bannerView;

    public void Start()
    {
        string appId = "ca-app-pub-6338977167328988~3985994970";

        MobileAds.Initialize(appId);

        this.RequestBanner();
    }

    private void RequestBanner()
    {
        string adUnitId = "ca-app-pub-6338977167328988/2098198238";

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
       
    }
    
    public void OnDestroy()
    {
        bannerView.Destroy();
    }

}