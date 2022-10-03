using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//Hecho por Antonio Izaguirre (Antoniza) (202010020281)
namespace Ejercicio1_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
