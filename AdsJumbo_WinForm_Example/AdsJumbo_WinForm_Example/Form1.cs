using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdsJumbo_WinForm_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
            
            SUPPORTED FRAMEWORK:
            .NET Framework 4.6.2 or above
            
            All Supported Ad Sizes and Ad Types:

            BANNER:
            -728x90
           - 160x600
           - 300x250
           - 300x600
           - 320x50
           - 468x60

            INTERSTITIAL:
           - Interstital Ads (fullscreen / popup ads)

           */

            // Show Ad Banner 728x90 - define: width, height, your_app_id
            bannerAds1.ShowAd(728, 90, "your_app_id");

            // Show Ad Banner 160x600 - define: width, height, your_app_id
            bannerAds2.ShowAd(160, 600, "your_app_id");

            // Show Ad Banner 300x250 - define: width, height, your_app_id
            bannerAds3.ShowAd(300, 250, "your_app_id");

            // Show Ad Banner 300x600 - define: width, height, your_app_id
            // bannerAds4.ShowAd(300, 600, "your_app_id");

            // Show Ad Banner 300x600 - define: width, height, your_app_id
            // bannerAds5.ShowAd(468, 60, "your_app_id");

            // Show Interstitial Ad - define your_app_id
            interstitialAd1.ShowInterstitialAd("");

            ///////////////////////
            ///// IMPORTANT! /////
            //////////////////////
            // In Form1.Designer.cs - Define always interstitial ad as a first in order, due to visibility on top / fullscreen without any disturbing elements, then our sdk can work as expected
            // Please check this example - open Form1Degisner.cs

            // TIPS:
            // - The best place is to show an interstitial ad when the app is fully loaded (eg. OnNavigated or your can simple timer await Task.Delay(2000) event)
            // - We recommend call at least 1x interstitial ad in your app (more is better for increase eCPM and RPM)
            // - You can also call interstitial ad unit when user click on any button (any button, play button, pause button, menu button, when app/game is loaded and others events)

            // CONTACT: 
            // info@adsjumbo.com
            // We will be happy to help you with the implementation AdsJumbo SDK just write us!

            // NOTE: 
            // LIVE ADS ARE AVAILABLE WHEN YOUR APP / GAME IS APPROVED, JUST HIT BUTTON "SUBMIT TO REVIEW"
        }
    }
}
