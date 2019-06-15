using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace wiwii
{
    public partial class AfterLoginPage : MasterDetailPage
    {
        public AfterLoginPage()
        {
            var masterPage = new UserMasterPage(this);
            Master = masterPage;
            Detail = new NavigationPage(new UserDetailPage());
        }
    }
}
