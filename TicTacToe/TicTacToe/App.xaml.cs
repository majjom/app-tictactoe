using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using TicTacToe.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]

namespace TicTacToe
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            
            MainPage = new NavigationPage(new HomePage())
            {
                BarBackgroundColor = Color.FromHex("#2196F3"),
                BarTextColor = Color.White
            };
		}

		protected override void OnStart ()
		{
            AppCenter.Start("android=9ab02d97-aa83-4a73-aeac-b9b69c58b723;" + "uwp={Your UWP App secret here};" + "ios={Your iOS App secret here}", typeof(Analytics), typeof(Crashes));

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
