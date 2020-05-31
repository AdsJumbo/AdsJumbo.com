//
// InterstitialAd.xaml.h
// Declaration of the InterstitialAd class
//

using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Interop;
using namespace Windows::UI::Xaml;
using namespace Platform;

using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Interop;

#pragma once

#include "InterstitialAd.g.h"

namespace AdsJumbo
{
	public delegate void OnAdErrorEventHandlerInterstitial(InterstitialAd^ sender);
	public delegate void OnAdClosedEventHandlerInterstitial(InterstitialAd^ sender);
	public delegate void OnAdErrorNoAdsEventHandlerInterstitial(InterstitialAd^ sender);
	public delegate void OnAdCompletedEventHandlerInterstitial(InterstitialAd^ sender);

	public ref class InterstitialAd sealed
	{
	public:
		InterstitialAd();
		void showInterstitial(Platform::String^ ApplicationId);
		void OnTick(Object ^ sender, Object ^ e);
		void OnTick2(Object ^ sender, Object ^ e);

		event OnAdErrorEventHandlerInterstitial^ OnAdError;
		void OnAdErrorEvent()
		{
			OnAdError(this);
		}

		event OnAdClosedEventHandlerInterstitial^ OnAdClosed;
		void OnAdClosedEvent()
		{
			OnAdClosed(this);
		}

		event OnAdErrorNoAdsEventHandlerInterstitial^ OnAdErrorNoAds;
		void OnAdErrorNoAdsEvent()
		{
			OnAdErrorNoAds(this);
		}

		event OnAdCompletedEventHandlerInterstitial^ OnAdCompleted;
		void OnAdCompletedEvent()
		{
			OnAdCompleted(this);
		}

	private:
		void popupadWebview_ScriptNotify(Platform::Object^ sender, Windows::UI::Xaml::Controls::NotifyEventArgs^ e);
		void popupadClose_Tapped(Platform::Object^ sender, Windows::UI::Xaml::Input::TappedRoutedEventArgs^ e);
	};
}
