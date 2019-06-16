using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Wiwii
{
    public partial class UserMasterPage : ContentPage
    {
		MasterDetailPage myMaster;
		public UserMasterPage(MasterDetailPage _myMaster)
        {
			myMaster = _myMaster;
			InitializeComponent();
        }

		void Speed_Handle_Clicked(object sender, System.EventArgs e)
		{
			myMaster.Detail = new NavigationPage(new WiWiiFirstPage());
			myMaster.IsPresented = false;
		}
        void Settings_Handle_Clicked(object sender, System.EventArgs e)
        {
            myMaster.Detail = new NavigationPage(new SettingsScreen());
            myMaster.IsPresented = false;
        }

    }
}
