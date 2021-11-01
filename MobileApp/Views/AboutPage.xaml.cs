using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private async void Calculator_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calculator());
        }
        private async void Pedometer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pedometer());
        }
        private async void Time_reminder_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Time_reminder());
        }
        private async void Device_status_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Device_status());
        }

    }
}