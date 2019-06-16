using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Wiwii
{
    public partial class SettingsScreen : ContentPage
    {
        public SettingsScreen()
        {
            InitializeComponent();
        }
        private async void ToolbarItem_ActivatedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new userProfile());
        }
        private async void speedTestSettingAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new speedTestSetting());
        }
        private async void historySettingAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new history());
        }
        private async void connectionSettingAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new currentConnection());
        }


    }
}
