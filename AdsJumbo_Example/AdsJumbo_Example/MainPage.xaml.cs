using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AdsJumbo_Example
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
            InterstitialAd.OnAdClosed += InterstitialAd_OnAdClosed;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Show Interstitial Ad - method: ShowInterstitialAd();
            InterstitialAd.ShowInterstitialAd();

            // TIPS:
            // - The best place is to show an interstitial ad when the app is fully loaded (eg. OnNavigated or your can simple timer await Task.Delay(2000) event)
            // - We recommend call at least 1x interstitial ad in your app (more is better for increase eCPM and RPM)
            // - You can also call interstitial ad unit when user click on any button (, any button, play button, pause button, menu button, when app/game is loaded and others)

            // CONTACT: 
            // info @adsjumbo.com
            // We will be happy to help you with the implementation AdsJumbo SDK just write us!

            // NOTE: 
            // LIVE ADS ARE AVAILABLE WHEN YOUR APP / GAME IS APPROVED, JUST HIT BUTTON "SUBMIT TO REVIEW" - Don't worry, our fill rate is 100% worldwide to maximize your revenue from ads
        }
        private void InterstitialAd_OnAdClosed(object sender, RoutedEventArgs e)
        {
            // When an Interstitial Ad is closed, just resume app / game according to your requirements
        }
    }
}
