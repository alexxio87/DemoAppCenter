using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


namespace EsempioConnessioneGitApp.Droid
{
    [Activity(Label = "EsempioConnessioneGitApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            AppCenter.Start("c08a6e83-b47f-4255-bcf9-b4f1fa4b3fd4",
                   typeof(Analytics), typeof(Crashes));
            AppCenter.Start("c08a6e83-b47f-4255-bcf9-b4f1fa4b3fd4", typeof(Analytics), typeof(Crashes));
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

