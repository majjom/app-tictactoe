using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Acr.UserDialogs;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TicTacToe.Droid
{
	[Activity (Label = "Tic-Tac-Toe", 
        Icon = "@drawable/icon", 
        MainLauncher = true, 
        ConfigurationChanges = 
        ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
    {
		protected override void OnCreate (Bundle bundle)
		{
            ToolbarResource = Resource.Layout.toolbar;
            TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate (bundle);

			Forms.Init (this, bundle);
            AppCenter.Start("9ab02d97-aa83-4a73-aeac-b9b69c58b723", typeof(Analytics), typeof(Crashes));
            LoadApplication (new App ());

            UserDialogs.Init(this);
		}
	}
}

