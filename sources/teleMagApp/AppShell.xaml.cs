using System;
using System.Collections.Generic;
using teleMagApp.ViewModels;
using teleMagApp.Views;
using Xamarin.Forms;

namespace teleMagApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
