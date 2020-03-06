using System;
using System.Collections.Generic;
using GenApp.Helpers;
using Xamarin.Forms;

namespace GenApp.Views
{
    public partial class LoginPage : ContentPage
    {
        ILoginManger lmi = null;
        public LoginPage(ILoginManger ilm)
        {
            InitializeComponent();
            this.lmi = ilm;
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
