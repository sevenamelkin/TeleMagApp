using System;
using teleMagApp.Services;
using teleMagApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace teleMagApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
