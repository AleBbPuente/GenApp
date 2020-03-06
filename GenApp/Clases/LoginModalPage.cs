using System;
using GenApp.Helpers;
using Xamarin.Forms;

namespace GenApp.Views
{
    public class LoginModalPage: CarouselPage
    {
        ContentPage login;
        public LoginModalPage(ILoginManger ilm)
        {
            login = new LoginPage(ilm);

        }
    }
}
