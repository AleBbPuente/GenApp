using System;
using GenApp.Helpers;
using Xamarin.Forms;

namespace GenApp.Views
{
    public class LoginModalPage : CarouselPage
    {
        ContentPage login;

        public LoginModalPage(ILoginManger ilm)
        {
            login = new LoginPage(ilm);
            this.Children.Add(login);
            MessagingCenter.Subscribe<ContentPage>(this, "Login", (sender) =>
                {
                this.SelectedItem = login;
            });

        }
    }
}
