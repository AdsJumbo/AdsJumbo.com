
// GENERATED BY UNITY
// DO NOT MODIFY, THIS FILE WILL BE OVERWRITTEN DURING NEXT BUILD
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;

namespace Unity
{
    public class UnityGenerated
    {
        public static void SetupDisplay()
        {
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape|DisplayOrientations.LandscapeFlipped|DisplayOrientations.Portrait|DisplayOrientations.PortraitFlipped;
			ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.Auto;
        }
    }
}
    