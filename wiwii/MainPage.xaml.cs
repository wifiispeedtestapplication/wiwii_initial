using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Wiwii
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public class MyEntry : Entry
        {
        }

        

        private async void Handle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
       

        private void Login_Handler(object sender, EventArgs e)
        {
            var myApp = Application.Current as App;
            myApp.OnLogin();
            //await Navigation.PushAsync(new WiWiiFirstPage());
        }
    }
}
