using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pedometer : ContentPage
    {
        int count = 0;
        int calories;
        int km;
        SensorSpeed speed = SensorSpeed.Game;
        public Pedometer()
        {
            InitializeComponent();
            calories = count / 20;
            km = count / 1242;
        }


        void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                count += 1;
                test1.Text = count.ToString();
                calories = count / 20;
                test2.Text = calories.ToString();
                km = count / 1242;
                test3.Text = km.ToString();
            });
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            //((ViewModels.PedometerViewModel)BindingContext).StartCommand.Execute(null);
            Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;
            Accelerometer.Start(speed);
        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            //((ViewModels.PedometerViewModel)BindingContext).StopCommand.Execute(null);
            Accelerometer.ShakeDetected -= Accelerometer_ShakeDetected;
            Accelerometer.Stop();
        }
    }
}