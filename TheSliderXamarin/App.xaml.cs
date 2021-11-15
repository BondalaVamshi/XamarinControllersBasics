using System;
using TheSliderXamarin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheSliderXamarin
{
    public partial class App : Application
    {
        public string DisplayLabelText { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new ButtonControler();
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
