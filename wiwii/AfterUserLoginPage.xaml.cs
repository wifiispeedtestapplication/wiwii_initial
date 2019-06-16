using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Wiwii
{
    public partial class AfterUserLoginPage : MasterDetailPage
    {
        public AfterUserLoginPage()
        {
			var masterPage = new UserMasterPage(this);
			Master = masterPage;
			Detail = new NavigationPage(new UserDetailPage());
		}
    }
}
