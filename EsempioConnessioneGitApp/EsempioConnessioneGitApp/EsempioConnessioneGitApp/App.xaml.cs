using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace EsempioConnessioneGitApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("android=c08a6e83-b47f-4255-bcf9-b4f1fa4b3fd4;" +
                  "uwp={Your UWP App secret here};" +
                  "ios=716b380e-3cfc-45dc-bbc1-8d5f0a7ec201;",
                  typeof(Analytics), typeof(Crashes));
            try
            {
                throw new Exception("errore");
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
            }
            // Handle when your app starts
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
