using System;
using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Plugin.LocalNotifications;

namespace GomEnd.Droid
{
    [Activity(Label = "GomEnd", Icon = "@drawable/icongo", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            ImageCircleRenderer.Init();
            UserDialogs.Init(this);
            global::Xamarin.FormsMaps.Init(this, bundle);
            LocalNotificationsImplementation.NotificationIconId = Resource.Drawable.ic_mr_button_connected_05_dark;
            LoadApplication(new App());
        }
    }
}

