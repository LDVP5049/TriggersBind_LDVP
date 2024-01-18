using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TriggersBind_LDVP.Vistas;

namespace TriggersBind_LDVP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaCategoria();
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
