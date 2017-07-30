using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
	public partial class ProductItemViewPage : ContentPage
	{
		public ProductItemViewPage()
		{
			InitializeComponent ();

			BindingContext = SampleData.Products[0];
		}
			
		private async void OnImageTapped(Object sender, EventArgs e){
			if (((Product)BindingContext).Name == "Ma famille")
			{
                var imagePreview =  new FamilleData ( (Product)BindingContext);
				await Navigation.PushModalAsync(new NavigationPage(imagePreview));

			}else{
				var imagePreview = new ProductImageFullScreenPage((Product)BindingContext);
				await Navigation.PushModalAsync(new NavigationPage(imagePreview));


			}

			
		}

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            
            DisplayAlert((e.Item as DemandeInfo).autorite, (e.Item as DemandeInfo).date + "\n" + (e.Item as DemandeInfo).raison,"OK");
        }
    }
}

