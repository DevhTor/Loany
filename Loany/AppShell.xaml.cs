//using Loany.ViewModels;
using Loany.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Loany
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ClientListPage), typeof(ClientListPage));
            Routing.RegisterRoute(nameof(NewClientPage), typeof(NewClientPage));
        }

        
    }
}
