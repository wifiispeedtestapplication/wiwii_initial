using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Wiwii
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private async void Back_Handler(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}
