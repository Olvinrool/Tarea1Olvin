using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1Olvin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Paginas.PaginaEntrada () );
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
