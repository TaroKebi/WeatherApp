using Android.App;
using Android.Content.PM;
using Android.OS;

namespace WeatherReport
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]

    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Android.OS.Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetColors();
        }

        private void SetColors()
        {
            if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Lollipop)
            {
                // Aqua.
                var hexColor = "#060723";
                // The thin bar at top of Android screen.
                Window.SetStatusBarColor(Android.Graphics.Color.ParseColor(hexColor));
                // The thicker bar at bottom of Android screen.
                Window.SetNavigationBarColor(Android.Graphics.Color.ParseColor(hexColor));
                // 透明にしたかったらこっち
                // Window.SetNavigationBarColor(Android.Graphics.Color.Transparent);
            }
        }
    }
}
