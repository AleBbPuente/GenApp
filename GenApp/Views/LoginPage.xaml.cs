using System;
using System.Collections.Generic;
using GenApp.Helpers;
using Xamarin.Forms;

namespace GenApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public static string NombreUsuario = "admin";
        ILoginManger iml = null;
       
        public LoginPage(ILoginManger ilm)
        {
            InitializeComponent();
            iml = ilm;
        }

        public LoginPage()
        {
        }

        void btnLoginClick (object sender, EventArgs e)

        {
            NombreUsuario = "admin";
            App.Current.Properties["usuario"] = NombreUsuario;
            App.Current.Properties["IsLoggedIn"] = true;

            iml.ShowMainPage();
        }

        public async void Login(object sender, EventArgs e)
        {
            var user = usuario.Text;
            var pass = password.Text;

            var userReal = "admin";
            var passReal = "admin";

            if (user == userReal && pass == passReal)
            {
              
            }
        }
    }
}
