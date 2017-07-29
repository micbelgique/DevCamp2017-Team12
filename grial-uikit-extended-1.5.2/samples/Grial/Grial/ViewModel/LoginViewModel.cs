using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial.ViewModel
{
    public class LoginViewModel
    {
        public ICommand LoginCommand { get; private set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
        }

        void Login()
        {
            //Application.Current.MainPage = new ProductsCarouselPage();
            Application.Current.MainPage = new RootPage(true);
        }
    }
}
