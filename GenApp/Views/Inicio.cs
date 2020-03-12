using System;

using Xamarin.Forms;

namespace GenApp.Views
{
    public class Inicio : ContentPage
    {
        public Inicio()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

