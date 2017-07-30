using System;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
	public partial class ProductImageFullScreenPage : ContentPage
	{
		private const uint animationDuration = 100;

		public ProductImageFullScreenPage ( Product product )
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar( this, false );
           
		}

	
		

		async void OnCloseButtonClicked( object sender, EventArgs args )
		{
			await Navigation.PopModalAsync();
		}
	}
}
