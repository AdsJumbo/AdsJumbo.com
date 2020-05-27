<img src="https://avatars1.githubusercontent.com/u/61216441?s=460&v=4" width="100" alt="AdsJumbo.com" data-canonical-src="https://avatars1.githubusercontent.com/u/61216441?s=460&v=4">  &nbsp;&nbsp;
<img src="https://adsjumbo.com/windows-store.png" width="100" alt="AdsJumbo.com - Windows Store Advertising SDK" data-canonical-src="https://adsjumbo.com/windows-store.png">

# AdsJumbo.com-SDK: Advertising SDK
This repository contains the AdsJumbo.com SDK for apps & games. This allows you to display advertisements in the apps & games published in the Windows Store. https://AdsJumbo.com

Download at NuGet: https://www.nuget.org/packages/AdsJumbo/

AdsJumbo SDK supports: Windows UWP Apps (Windows 10, C# XAML) and Unity3D Games</br>
If you have any questions about SDK or need help with implementation, please email us at:
info@adsjumbo.com

# Monetize with AdsJumbo Ads
Increase your revenue opportunities by putting ads in your apps by using the AdsJumbo Advertising SDK. Our monetization platform offers a variety of ad types including banner ads, interstitial ads and native ads. Drive advertising revenue by choosing from a variety of ad formats that can be seamlessly integrated into your Windows apps and games. Our advertising SDK you can simply implement it into your existing application or game (also Unity 3D game).

# Ad Formats:
# 1. Banner Ads
These are static display ads that utilize a portion of a page in an app or web site. These are typically located at the top, left or bottom of your primary content and prompt the users to install some apps or view brands or products. This is still the most popular ad format in the industry today.
# 2. Interstitial Ads
These are full-screen ads that typically require the user to click through to continue with the app or the game. These generate more user engagement than standard banner ads and hence generate more ad revenue.

# 3. Native Ads
These are component-based ads - each piece of the advertiser's creative - is delivered to the app or web page as individual elements that you can choose to stitch into your page in any manner that fits your scenario the best. You can generate an ad creative optimizing on the style, look and feel and behavior to be very similar to the rest of your app screen or page in order to keep the most unobrtrusive end user experience.

# Getting Started
# Step 1: Adding References - NuGet package
Import the AdsJumbo SDK as a reference as dependency of your Windows Visual Studio project. Click on ‘Manage NuGet Packages’, search name package ‘AdsJumbo’ in your nuget Package Manager console. Download latest version.<br/>
Just click on button ‘Install‘ and that's all. (Don't forget to install all depencies Newtonsoft.Json>= 9.0.1)

<p><img src="https://adsjumbo.com/info/adsjumbo-nuget.png"  width="550" alt=""></p>

Add Content URI in "Package.appxmanifest" - URL: https://adsjumbo.com/
<p><img src="https://adsjumbo.com/info/adsjumbo-contenturi.png"  width="550" alt=""></p>

# Step 2: Add XAML code 
Add in your XAML file (eg. MainPage.xaml) following codes:<br/>
- In the Header section:
<pre><code>xmlns:adsjumbo="using:AdsJumbo"</code></pre>

- In the Grid or anywhere on the XAML page just add Ad tag:<br/>
Ad Tag you get when you login into your DASHBOARD - MY APPS - SELECT YOUR APP - GET AD TAG:<br/>
Get your Ad Tags at: https://adsjumbo.com/login

<p><img src="https://adsjumbo.com/info/adsjumbo-xaml.png"  width="550" alt=""></p>

- NOTE: For interstitial ad, please invoke in C# code in the appropriate moment (use as many times as you like):
<pre><code>InterstitialAd.ShowInterstitialAd();</code></pre>

- NOTE: For Unity3D Games, please remove from .csproj file following block:
<pre><code>AllowedReferenceRelatedFileExtensions</code></pre>
 
# Step 3: Submit the App to the Review process
Hit the button "Request Activation"</br>
When your game is approved, your ads will be live and you can see real-time reports under your dashboard and enjoy your earnings!

# Supporting Ad Sizes:
Banner Ads:
- 160x600
- 728x90
- 300x600
- 160x1000 (Full Size Skyscaper Banner)
- 320x50
- 300x50
- 468x60

Interstitial Ads:
- Fullscreen / Popup Banner & Video

# Events:
 # Events for Banner Ads:
OnAdError = When an Error Occurred on Banner Ad
<pre><code>BannerAd.OnAdError += BannerAd_OnAdError;</code></pre>
OnAdErrorNoAds = When No Ads are Available on Banner Ad
<pre><code>BannerAd.OnAdErrorNoAds += BannerAd_OnAdErrorNoAds;</code></pre>

 # Events for Interstitial Ads:
OnAdClosed = When an Interstitial Ad is closed
<pre><code>InterstitialAd.OnAdClosed += InterstitialAd_OnAdClosed;</code></pre>
OnAdError = When an Error Occurred on Interstitial Ad
<pre><code>InterstitialAd.OnAdError += InterstitialAd_OnAdError;</code></pre>
OnAdErrorNoAds = When an No Ads Available on Interstitial Ad
<pre><code>InterstitialAd.OnAdErrorNoAds += InterstitialAd_OnAdErrorNoAds;</code></pre>

# If you want to add programmatically:
Banner Ads:
<pre><code>
BannerAd bannerads = new BannerAd();
bannerads.WidthAd = 728;                                        // Define Width Ad Unit
bannerads.HeightAd = 90;                                        // Define Height Ad Unit
bannerads.ApplicationId = "your_app_id";                        // Define Application ID
bannerads.VerticalAlignment = VerticalAlignment.Bottom;         // Vertical Aligment
bannerads.HorizontalAlignment = HorizontalAlignment.Center;     // Horizontal Aligment
LayoutRoot.Children.Add(bannerads);                             // Load in Grid programmatically
</code></pre>

Interstitial Ads:
<pre><code>
InterstitialAd interstitialads = new InterstitialAd();
interstitialads.ApplicationId = "your_app_id";                  // Define Application ID
LayoutRoot.Children.Add(bannerads);                             // Load in Grid programmatically
</code></pre>

Invoke an Interstitial Ads:
<pre><code>
InterstitialAd.ShowInterstitialAd();
</code></pre>

# Examples:
- For Windows 10 Project, please download and open:</br>
<a href="https://github.com/AdsJumbo/AdsJumbo.com/archive/master.zip">AdsJumbo_Example</a>

- For Unity3D games - Windows 10, please download and open:</br>
<a href="https://github.com/AdsJumbo/AdsJumbo.com/archive/master.zip">AdsJumbo_Example_Unity3D</a>

Download all examples: <a href="https://github.com/AdsJumbo/AdsJumbo.com/archive/master.zip">Download Here</a>
Please always install the latest version of the NuGet package.

# UPDATE NOTES:
- added OnAdClosed, OnAdError, OnAdErrorNoAds events
- Minor fixes

# Support:
If you have any technical questions or comments, please email us at:
info@adsjumbo.com

Or simply check documentation at:
https://adsjumbo.com/sdk
