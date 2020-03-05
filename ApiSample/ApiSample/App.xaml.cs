using ApiSample.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DrinksPage();
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
