//
// MainPage.xaml.h
// Declaration of the MainPage class.
//

#pragma once

#include "MainPage.g.h"

namespace AdsJumbo_Example_Native
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public ref class MainPage sealed
	{
	public:
		MainPage();

		void OnAdErrorBanner(AdsJumbo::BannerAd ^sender);
		void OnAdErrorNoAdsBanner(AdsJumbo::BannerAd ^sender);
		void OnAdClosedInterstitial(AdsJumbo::InterstitialAd ^sender);
		void OnAdErrorInterstitial(AdsJumbo::InterstitialAd ^sender);
		void OnAdErrorNoAdsInterstitial(AdsJumbo::InterstitialAd ^sender);
	};
}
