using System;
using GenApp.Helpers;
using GenApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GenApp
{
    public partial class App : Application, ILoginManger
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public void ShowMainPage()
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
