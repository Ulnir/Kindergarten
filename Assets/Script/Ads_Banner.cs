using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Ads_Banner : MonoBehaviour
{
    private BannerView bannerView;
    

    public void Start()
    {
#if UNITY_ANDROID
        string appId = "ca-app-pub-4934040369908276~5983696835";
#elif UNITY_IPHONE
            string appId = "ca-app-pub-4934040369908276~5983696835";
#else
            string appId = "unexpected_platform";
#endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        this.RequestBanner();
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-4934040369908276/1885982805";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-4934040369908276/1885982805";
#else
            string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }

    public void Destroy()
    {
        bannerView.Destroy();
    }
}
