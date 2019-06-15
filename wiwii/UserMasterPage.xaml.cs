using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace wiwii
{
    public partial class UserMasterPage : ContentPage
    {
        MasterDetailPage myMaster;
        public UserMasterPage(MasterDetailPage _myMaster)
        {
            myMaster = _myMaster;
            InitializeComponent();
        }
    }
}
