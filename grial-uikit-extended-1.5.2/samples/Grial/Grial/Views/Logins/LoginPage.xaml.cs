using System;
using System.Collections.Generic;
using UXDivers.Artina.Grial.ViewModel;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar(this, false);
            this.BindingContext = new LoginViewModel();
        }

		public async void OnSignupStackTapped (object sender, EventArgs e) {
			if (LoginPage.IsPageInNavigationStack<SignUpPage> (Navigation)) {
				await Navigation.PopAsync ();
				return;
			}

			var signUpPage = new SignUpPage();
			await Navigation.PushAsync( signUpPage );
		}

		public static bool IsPageInNavigationStack<TPage>(INavigation navigation) where TPage : Page {
			if (navigation.NavigationStack.Count > 1) {
				var last = navigation.NavigationStack [navigation.NavigationStack.Count - 2];

				if (last is TPage) {
					return true;
				}
			}
			return false;
		}
	}
}