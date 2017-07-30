using System;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
	public partial class VoitureData : ContentPage
	{
		private const uint animationDuration = 100;

        public Product product;

		public VoitureData ( Product product )
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar( this, false );

            BindingContext = product;
        }

	
		

		async void OnCloseButtonClicked( object sender, EventArgs args )
		{
			await Navigation.PopModalAsync();
		}
	}
}
