//
// MainPage.xaml.cpp
// Implementation of the MainPage class.
//

#include "pch.h"
#include "MainPage.xaml.h"

using namespace AdsJumbo_Example_Native;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

using namespace AdsJumbo;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

MainPage::MainPage()
{
	InitializeComponent();

	// Ad Banner 160x600 - define:your_app_id, width, height
	bannerLeft->showBanner("your_app_id", 160, 600);

	// Ad Banner 160x600 - define your_app_id, width, height
	bannerRight->showBanner("your_app_id", 160, 600);

	// Ad Banner 728x90 - define your_app_id, width, height
	bannerBottom->showBanner("your_app_id", 728, 90);

	// Show Interstitial Ad - define your_app_id
	bannerInterstitial->showInterstitial("your_app_id");


	/*
	Events Banner Ads
	- OnAdError
	- OnAdErrorNoAds
	*/
	bannerLeft->OnAdError      += ref new AdsJumbo::OnAdErrorEventHandlerBanner(this, &AdsJumbo_Example_Native::MainPage::OnAdErrorBanner);
	bannerLeft->OnAdErrorNoAds += ref new AdsJumbo::OnAdErrorNoAdsEventHandlerBanner(this, &AdsJumbo_Example_Native::MainPage::OnAdErrorNoAdsBanner);

	/* 
	Events Interstitial Ads
	- OnAdClosed
	- OnAdError
	- OnAdErrorNoAds
	*/
	bannerInterstitial->OnAdClosed     += ref new AdsJumbo::OnAdClosedEventHandlerInterstitial(this, &AdsJumbo_Example_Native::MainPage::OnAdClosedInterstitial);
	bannerInterstitial->OnAdError      += ref new AdsJumbo::OnAdErrorEventHandlerInterstitial(this, &AdsJumbo_Example_Native::MainPage::OnAdErrorInterstitial);
	bannerInterstitial->OnAdErrorNoAds += ref new AdsJumbo::OnAdErrorNoAdsEventHandlerInterstitial(this, &AdsJumbo_Example_Native::MainPage::OnAdErrorNoAdsInterstitial);
}


void AdsJumbo_Example_Native::MainPage::OnAdErrorBanner(AdsJumbo::BannerAd ^sender)
{
	// When an Error Occurred on Banner Ad
}


void AdsJumbo_Example_Native::MainPage::OnAdErrorNoAdsBanner(AdsJumbo::BannerAd ^sender)
{
	// When No Ads are Available on Banner Ad
}


void AdsJumbo_Example_Native::MainPage::OnAdClosedInterstitial(AdsJumbo::InterstitialAd ^sender)
{
	// When an Interstitial Ad is closed
}


void AdsJumbo_Example_Native::MainPage::OnAdErrorInterstitial(AdsJumbo::InterstitialAd ^sender)
{
	// When an Error Occurred on Interstitial Ad
}


void AdsJumbo_Example_Native::MainPage::OnAdErrorNoAdsInterstitial(AdsJumbo::InterstitialAd ^sender)
{
	// When an No Ads Available on Interstitial Ad
}
