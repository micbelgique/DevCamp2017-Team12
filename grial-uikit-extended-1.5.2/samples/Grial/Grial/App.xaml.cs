using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UXDivers.Artina.Grial
{
	//[XamlCompilation (XamlCompilationOptions.Skip)]
	public partial class App : Application
	{
		public static MasterDetailPage MasterDetailPage;

		public App ()
		{
			new Data();

			InitializeComponent ();

			MainPage = GetMainPage();

			MainPage.SetValue (NavigationPage.BarTextColorProperty, Color.White);
		}
			
		public static Page GetMainPage()
		{
            //return new RootPage(true);
            return new LoginPage();
            //return new SocialPage();
        }
	}
}