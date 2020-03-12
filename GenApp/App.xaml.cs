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

            Current = this;
            var isLoggedIn = Properties.ContainsKey("IsLoggedIn") ? (bool)Properties["IsLoggedIn"] : false;
            if (isLoggedIn)

                MainPage = new Inicio();
            else
                MainPage = new LoginModalPage(this); 
        }

        public void ShowMainPage()
        {
            MainPage = new Inicio();
        }

        public void Logout()
        {
            Properties["IsLoggedIn"] = false;
            MainPage = new LoginModalPage(this);
        }

        static ILoginManger loginManager;
        public static App Curre;
        public static int val;
    }
}
