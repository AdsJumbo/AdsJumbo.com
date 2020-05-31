//
// BannerAd.xaml.h
// Declaration of the BannerAd class
//

using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Interop;
using namespace Windows::UI::Xaml;
using namespace Platform;

using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Interop;

#pragma once

#include "BannerAd.g.h"
	
namespace AdsJumbo
{
	public delegate void OnAdErrorEventHandlerBanner(BannerAd^ sender);
	public delegate void OnAdErrorNoAdsEventHandlerBanner(BannerAd^ sender);
	public delegate void OnAdRefreshedEventHandlerBanner(BannerAd^ sender);

	public ref class BannerAd sealed
	{
	public:
		BannerAd();
		void showBanner(Platform::String^ ApplicationId, int Width, int Height);

		event OnAdErrorEventHandlerBanner^ OnAdError;
		void OnAdErrorEvent()
		{
			OnAdError(this);
		}

		event OnAdErrorNoAdsEventHandlerBanner^ OnAdErrorNoAds;
		void OnAdErrorNoAdsEvent()
		{
			OnAdErrorNoAds(this);
		}

		event OnAdRefreshedEventHandlerBanner^ OnAdRefreshed;
		void OnAdRefreshedEvent()
		{
			OnAdRefreshed(this);
		}

	private:
		void banner_ScriptNotify(Platform::Object^ sender, Windows::UI::Xaml::Controls::NotifyEventArgs^ e);
	};
}
