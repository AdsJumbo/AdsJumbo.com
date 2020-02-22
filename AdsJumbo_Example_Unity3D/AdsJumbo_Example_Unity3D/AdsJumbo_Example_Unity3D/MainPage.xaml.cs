using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine.Windows;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using UnityPlayer;

namespace AdsJumbo_Example_Unity3D
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private WinRTBridge.WinRTBridge _bridge;

        private SplashScreen splash;
        private Rect splashImageRect;
        private WindowSizeChangedEventHandler onResizeHandler;
#if UNITY_WP_8_1
        private TypedEventHandler<DisplayInformation, object> onRotationChangedHandler;
#endif
        private bool isPhone = false;

        public MainPage()
        {
            this.InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Required;

            AppCallbacks appCallbacks = AppCallbacks.Instance;
            // Setup scripting bridge
            _bridge = new WinRTBridge.WinRTBridge();
            appCallbacks.SetBridge(_bridge);

            bool isWindowsHolographic = false;

#if UNITY_HOLOGRAPHIC
            // If application was exported as Holographic check if the deviceFamily actually supports it,
            // otherwise we treat this as a normal XAML application
            string deviceFamily = Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily;
            isWindowsHolographic = String.Compare("Windows.Holographic", deviceFamily) == 0;
#endif

            if (isWindowsHolographic)
            {
                appCallbacks.InitializeViewManager(Window.Current.CoreWindow);
            }
            else
            {
                appCallbacks.RenderingStarted += () => { RemoveSplashScreen(); };

#if UNITY_UWP
                if (Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Phone.PhoneContract", 1))
                    isPhone = true;
#endif
#if !UNITY_WP_8_1
                appCallbacks.SetKeyboardTriggerControl(this);
#else
                isPhone = true;
#endif
                appCallbacks.SetSwapChainPanel(GetSwapChainPanel());
                appCallbacks.SetCoreWindowEvents(Window.Current.CoreWindow);
                appCallbacks.InitializeD3DXAML();

                splash = ((App)App.Current).splashScreen;
                GetSplashBackgroundColor();
                OnResize();
                onResizeHandler = new WindowSizeChangedEventHandler((o, e) => OnResize());
                Window.Current.SizeChanged += onResizeHandler;

#if UNITY_WP_8_1
                onRotationChangedHandler = new TypedEventHandler<DisplayInformation, object>((di, o) => { OnRotate(di); });
                ExtendedSplashImage.RenderTransformOrigin = new Point(0.5, 0.5);
                var displayInfo = DisplayInformation.GetForCurrentView();
                displayInfo.OrientationChanged += onRotationChangedHandler;
                OnRotate(displayInfo);

                SetupLocationService();
#endif
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            splash = (SplashScreen)e.Parameter;
            OnResize();
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

        private void OnResize()
        {
            if (splash != null)
            {
                splashImageRect = splash.ImageLocation;
                PositionImage();
            }
        }

#if UNITY_WP_8_1
        private void OnRotate(DisplayInformation di)
        {
            // system splash screen doesn't rotate, so keep extended one rotated in the same manner all the time
            int angle = 0;
            switch (di.CurrentOrientation)
            {
                case DisplayOrientations.Landscape:
                    angle = -90;
                    break;
                case DisplayOrientations.LandscapeFlipped:
                    angle = 90;
                    break;
                case DisplayOrientations.Portrait:
                    angle = 0;
                    break;
                case DisplayOrientations.PortraitFlipped:
                    angle = 180;
                    break;
            }
            var rotate = new RotateTransform();
            rotate.Angle = angle;
            ExtendedSplashImage.RenderTransform = rotate;
        }

#endif

        private void PositionImage()
        {
            var inverseScaleX = 1.0f;
            var inverseScaleY = 1.0f;
            if (isPhone)
            {
                inverseScaleX = inverseScaleX / DXSwapChainPanel.CompositionScaleX;
                inverseScaleY = inverseScaleY / DXSwapChainPanel.CompositionScaleY;
            }

            ExtendedSplashImage.SetValue(Canvas.LeftProperty, splashImageRect.X * inverseScaleX);
            ExtendedSplashImage.SetValue(Canvas.TopProperty, splashImageRect.Y * inverseScaleY);
            ExtendedSplashImage.Height = splashImageRect.Height * inverseScaleY;
            ExtendedSplashImage.Width = splashImageRect.Width * inverseScaleX;
        }

        private async void GetSplashBackgroundColor()
        {
            try
            {
                StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///AppxManifest.xml"));
                string manifest = await FileIO.ReadTextAsync(file);
                int idx = manifest.IndexOf("SplashScreen");
                manifest = manifest.Substring(idx);
                idx = manifest.IndexOf("BackgroundColor");
                if (idx < 0)  // background is optional
                    return;
                manifest = manifest.Substring(idx);
                idx = manifest.IndexOf("\"");
                manifest = manifest.Substring(idx + 1);
                idx = manifest.IndexOf("\"");
                manifest = manifest.Substring(0, idx);
                int value = 0;
                bool transparent = false;
                if (manifest.Equals("transparent"))
                    transparent = true;
                else if (manifest[0] == '#') // color value starts with #
                    value = Convert.ToInt32(manifest.Substring(1), 16) & 0x00FFFFFF;
                else
                    return; // at this point the value is 'red', 'blue' or similar, Unity does not set such, so it's up to user to fix here as well
                byte r = (byte)(value >> 16);
                byte g = (byte)((value & 0x0000FF00) >> 8);
                byte b = (byte)(value & 0x000000FF);

                await CoreWindow.GetForCurrentThread().Dispatcher.RunAsync(CoreDispatcherPriority.High, delegate()
                    {
                        byte a = (byte)(transparent ? 0x00 : 0xFF);
                        ExtendedSplashGrid.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
                    });
            }
            catch (Exception)
            {}
        }

        public SwapChainPanel GetSwapChainPanel()
        {
            return DXSwapChainPanel;
        }

        public void RemoveSplashScreen()
        {
            DXSwapChainPanel.Children.Remove(ExtendedSplashGrid);
            if (onResizeHandler != null)
            {
                Window.Current.SizeChanged -= onResizeHandler;
                onResizeHandler = null;

#if UNITY_WP_8_1
                DisplayInformation.GetForCurrentView().OrientationChanged -= onRotationChangedHandler;
                onRotationChangedHandler = null;
#endif
            }
        }

#if !UNITY_WP_8_1
        protected override Windows.UI.Xaml.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
        {
            return new UnityPlayer.XamlPageAutomationPeer(this);
        }

#else
        // This is the default setup to show location consent message box to the user
        // You can customize it to your needs, but do not remove it completely if your application
        // uses location services, as it is a requirement in Windows Store certification process
        private async void SetupLocationService()
        {
            AppCallbacks appCallbacks = AppCallbacks.Instance;
            if (!appCallbacks.IsLocationCapabilitySet())
            {
                return;
            }

            const string settingName = "LocationContent";
            bool userGaveConsent = false;

            object consent;
            var settings = Windows.Storage.ApplicationData.Current.LocalSettings;
            var userWasAskedBefore = settings.Values.TryGetValue(settingName, out consent);

            if (!userWasAskedBefore)
            {
                var messageDialog = new Windows.UI.Popups.MessageDialog("Can this application use your location?", "Location services");

                var acceptCommand = new Windows.UI.Popups.UICommand("Yes");
                var declineCommand = new Windows.UI.Popups.UICommand("No");

                messageDialog.Commands.Add(acceptCommand);
                messageDialog.Commands.Add(declineCommand);

                userGaveConsent = (await messageDialog.ShowAsync()) == acceptCommand;
                settings.Values.Add(settingName, userGaveConsent);
            }
            else
            {
                userGaveConsent = (bool)consent;
            }

            if (userGaveConsent)
            {   // Must be called from UI thread
                appCallbacks.SetupGeolocator();
            }
        }

#endif
    }
}
