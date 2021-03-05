<img src="https://avatars1.githubusercontent.com/u/61216441?s=460&v=4" width="100" alt="AdsJumbo.com" data-canonical-src="https://avatars1.githubusercontent.com/u/61216441?s=460&v=4">  &nbsp;&nbsp;
<img src="https://adsjumbo.com/windows-store.png" width="100" alt="AdsJumbo.com - Windows Store Advertising SDK" data-canonical-src="https://adsjumbo.com/windows-store.png">

# AdsJumbo.com-SDK: Advertising SDK
This repository contains the AdsJumbo.com SDK for Windows 10 and desktop apps & games. This allows you to display advertisements in the apps & games published in Windows Store and as well in the classic Windows apps (WinForm & WPF desktop apps). AdsJumbo.com provides ad solution for Windows 10 developers (Windows Store) and desktop developers (eg. Softpedia). Visit: https://AdsJumbo.com 💻 📱 🚀

💻 Download at NuGet: https://www.nuget.org/packages/AdsJumbo/
</br>
ℹ️ Additional support: info@adsjumbo.com (please send us a screenshot with your issue from Visual Studio or app)

AdsJumbo SDK supports: Windows UWP Apps (Windows 10, C# XAML, C++ / IL2CPP / DirectX, WinJS), Unity3D Games (Windows Store) and WinForm & WPF desktop apps (eg. from Softpedia)</br>

📌 LAST UPDATE: 
- Added WinForm and WPF support .NET Framework 4.6.2  ➡️ <a href="https://www.nuget.org/packages/AdsJumbo.WinForm.WPF/">NuGet package for WinForm</a></br>
- Added C++ / DirectX / IL2CPP / Unity3D IL2CPP games ➡️ <a href="https://www.nuget.org/packages/AdsJumbo.Native/">NuGet package for C++</a></br>

# AdsJumbo SDK is available for all UWP projects:</br>
<pre>
C#                       = <a href="https://www.nuget.org/packages/AdsJumbo/">NuGet package</a></br>
C++ / IL2CPP / DirectX   = <a href="https://www.nuget.org/packages/AdsJumbo.Native/">NuGet package for C++ apps and IL2CPP games</a></br>
WinJS SDK                = SDK for HTML5 apps & games is provided on the request, <a href="mailto:info@adsjumbo.com">please contact us</a></br>
WinForm / WPF            = <a href="https://www.nuget.org/packages/AdsJumbo.Native/">NuGet package for WinForm & WPF apps and games</a></br>
</pre></br>
If you have any questions about SDK or need help with implementation as well for additional framework or any .NET platform, please email us at:
<a href="mailto:info@adsjumbo.com">info@adsjumbo.com</a></br>

# Monetize with AdsJumbo Ads
Increase your revenue opportunities by putting ads in your apps by using the AdsJumbo Advertising SDK. Our monetization platform offers a variety of ad types including banner ads, interstitial ads and native ads. Drive advertising revenue by choosing from a variety of ad formats that can be seamlessly integrated into your Windows apps and games. Our advertising SDK you can simply implement into your existing Windows 10 & UWP application or game (also Unity 3D game). </br></br>
Supported architecture x86, x64, ARM and .NET platform

# Ad Formats:
# 1. Banner Ads
These are static display ads that utilize a portion of a page in an app or web site. These are typically located at the top, left or bottom of your primary content and prompt the users to install some apps or view brands or products. This is still the most popular ad format in the industry today.
# 2. Interstitial Ads
These are full-screen ads that typically require the user to click through to continue with the app or the game. These generate more user engagement than standard banner ads and hence generate more ad revenue.

# 3. Native Ads
These are component-based ads - each piece of the advertiser's creative - is delivered to the app or web page as individual elements that you can choose to stitch into your page in any manner that fits your scenario the best. You can generate an ad creative optimizing on the style, look and feel and behavior to be very similar to the rest of your app screen or page in order to keep the most unobtrusive end user experience.

# 🔴 Getting Started
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
When your game is approved, your ads will be live and you can see real-time reports under your dashboard and enjoy your earnings!</br>
NOTE: The limit of ad units in the app is not limited, you can use them as much as you want.

# Supporting Ad Sizes:
Banner Ads:
- 728x90
- 160x600
- 300x250
- 300x600
- 160x1000 (Full Size Skyscaper Banner)
- 320x50
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
<pre><code>BannerAd bannerads = new BannerAd();
bannerads.WidthAd = 728;                                            // Define Width Ad Unit
bannerads.HeightAd = 90;                                            // Define Height Ad Unit
bannerads.ApplicationId = "your_app_id";                            // Define Application ID
bannerads.VerticalAlignment = VerticalAlignment.Bottom;             // Vertical Alignment
bannerads.HorizontalAlignment = HorizontalAlignment.Center;         // Horizontal Alignment
LayoutRoot.Children.Add(bannerads);                                 // Load in Grid Programmatically</code></pre>

Interstitial Ads:
<pre><code>InterstitialAd interstitialads = new InterstitialAd();
interstitialads.ApplicationId = "your_app_id";                      // Define Application ID
LayoutRoot.Children.Add(interstitialads);                           // Load in Grid Programmatically</code></pre>

Invoke an Interstitial Ads:
<pre><code>InterstitialAd.ShowInterstitialAd();</code></pre>
<br/><br/>
# 🔴 For C++ / IL2CPP / DirectX apps & games
Please download package from NuGet called "AdsJumbo.Native" - this package is for C ++ projects and IL2CPP Unity3D games.
This allows you to display banner and interstitial ads in the C++ apps & games published in the Windows Store.</br> 
Download at NuGet: https://www.nuget.org/packages/AdsJumbo.Native/</br> 
Please follow steps below, implementation takes almost 3-5 minutes.

# Step 1: Adding References - NuGet package
Import the AdsJumbo.Native SDK as a reference as dependency of your Windows Visual Studio project. Click on ‘Manage NuGet Packages’, search name package ‘AdsJumbo.Native’ in your nuget Package Manager console. Download latest version.<br/>
Just click on button ‘Install‘ and that's all.<br/>
Add Content URI in "Package.appxmanifest" - URL: https://adsjumbo.com/

# Step 2: Add XAML code and C++ code
Add in your XAML file (eg. MainPage.xaml) following codes:<br/>
- In the Header section:
<pre><code>xmlns:adsjumbo="using:AdsJumbo"</code></pre>

- In the Grid or anywhere on the XAML page just add Ad tag:<br/>
<pre><code>
 < adsjumbo:BannerAd x:Name="bannerLeft" 
                           VerticalAlignment="Center"
                           HorizontalAlignment="Left" / >
                           
 < adsjumbo:InterstitialAd x:Name="bannerInterstitial" / >
</code> </pre>

- For banner ad, please invoke in C++ code (define APP ID, width ad, height ad)
<pre><code>bannerLeft->showBanner("your_app_id", 160, 600);</code></pre>

- For interstitial ad, please invoke in C++ code in the appropriate moment (use as many times as you like):
<pre><code>bannerInterstitial->showInterstitial("your_app_id");</code></pre>

# Step 3: Submit the App to the Review process
Hit the button "Request Activation"</br>
When your game is approved, your ads will be live and you can see real-time reports under your dashboard and enjoy your earnings!</br>
NOTE: The limit of ad units in the app is not limited, you can use them as much as you want.<br/>
<br/><br/>
# 🔴 For WinForm / WPF apps & games
Please download package from NuGet called "AdsJumbo.WinForm.WPF" - this package is for WinForm / WPF apps & games.
This allows you to display banner and interstitial ads in the dekstop apps & games or on any WinForm and WPF apps</br> 
Download at NuGet: https://www.nuget.org/packages/AdsJumbo.WinForm.WPF/

# Step 1: Adding References - NuGet package
Import the AdsJumbo.WinForm.WPF SDK as a reference as dependency of your Windows Visual Studio project. Click on ‘Manage NuGet Packages’, search name package ‘AdsJumbo.WinForm.WPF’ in your nuget Package Manager console. Download latest version.<br/>
Just click on button ‘Install‘ and that's all.<br/>

# Step 2: Add your ad unit and invoke advertisement
Drag and drop ad unit in your designer from menu "Toolbox" - "AdsJumboWinForm" - "BannerAds" or "InterstitialAds":<br/>
Place that ad unit component anywhere in your WinForm app, you can use more ad units on same page.<br/>
We recommend using at least one interstitial ad for better performance in terms if revenue. 

- For banner ad, please invoke in .cs code (width ad, height ad, define APP ID,)
<pre><code>bannerAds.ShowAd(728, 90, "your_app_id");</code></pre>

- For interstitial ad, please invoke in .cs code in the appropriate moment (use as many times as you like):
<pre><code>interstitialAd.ShowInterstitialAd("your_app_id");</code></pre>

# Step 3: Submit the App to the Review process
Hit the button "Request Activation"</br>
When your game is approved, your ads will be live and you can see real-time reports under your dashboard and enjoy your earnings!</br>
NOTE: The limit of ad units in the app is not limited, you can use them as much as you want.

# 🚩 Examples:
- For Windows 10 Project, please download and open:</br>
<a href="https://github.com/AdsJumbo/AdsJumbo.com/archive/master.zip">AdsJumbo_Example</a>

- For Unity3D games - Windows 10, please download and open:</br>
<a href="https://github.com/AdsJumbo/AdsJumbo.com/archive/master.zip">AdsJumbo_Example_Unity3D</a>

- For C++ apps - Windows 10, please download and open:</br>
<a href="https://github.com/AdsJumbo/AdsJumbo.com/archive/master.zip">AdsJumbo_Native_Example</a>

- For IL2CPP Unity3D games - Windows 10, please download and open:</br>
<a href="https://drive.google.com/file/d/1RTzn6THfepLevmw6JRo1dopcIJ4foCjq/">AdsJumbo_L2CPP_Unity3D_Example</a>

- For WinJS apps & games - Windows 10, please download and open:</br>
<a href="https://drive.google.com/file/d/1PBu6BjlFyWQFlApl3G85Cur62OkqO5cJ/">AdsJumbo_WinJS_Example</a>

- For WinForm / WPF apps & games - advertising for desktop apps, please download and open:</br>
<a href="https://github.com/AdsJumbo/AdsJumbo.com/archive/master.zip">AdsJumbo_WinForm_Example</a>

Download all examples: <a href="https://github.com/AdsJumbo/AdsJumbo.com/archive/master.zip">Download Here</a>

Please always install the latest version of the NuGet package available at https://www.nuget.org/packages/AdsJumbo/
</br>
The AdsJumbo SDK is constantly updated and maintained.</br>
Always install the latest release of SDK which which is maintained.

# ✔️ UPDATE NOTES:
- Added support for WinForm and WPF apps & games
- Added support for C++ architecture x64 and ARM
- New NuGet package for C++ / DirectX / IL2CPP / Unity3D IL2CPP games
- New SDK for WinJS (for Windows 10 apps based on HTML5 and JavaScript)
- Updated GitHub documentation
- Added OnAdClosed, OnAdError, OnAdErrorNoAds events
- Minor fixes

# ❓ FAQ:
How much time will it take to implement the SDK?</br>
- Implementation usually takes 3-5 minutes. It's very easy and simple even for beginners.</br>

Why I must add content URI in "Package.appxmanifest"?</br>
- This is only needed for the interstitial unit, to invoke event "close ad". This value allows you to close the interstitial ad. If you don't want to use it in your app, you don't have to, but then you won't be able to use interstitial ads thus only banner ads</br>

When are available "live" ads?</br>
- Live ads are available after approval your app or game. Just add your app, hit the button "submit to review", this is routine check by our QA team. If you have any problems with SDK implementation or any questions do not hesitate to <a href="mailto:info@adsjumbo.com"> contact us.</a></br>

Is there any exclusivity ?</br>
- Definitely no! It is always up to what you to decide. You can use more ad providers at the same time to increase your earnings. With us there is no condition of exclusivity. Your satisfaction is always important.</br>

Can I use more ad units on same page / app?</br>
- Yes, definitely. You can use multiple ad units on a page / app. At the same time, We recommend using at least one interstitial ad for better performance in term if revenue.
</br>

# Support:
If you have any technical questions or comments, please email us at:
info@adsjumbo.com

Or simply check GitHub documentation here or at:
https://adsjumbo.com/sdk
