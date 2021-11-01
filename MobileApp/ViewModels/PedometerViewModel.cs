using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace MobileApp.ViewModels
{
    public class PedometerViewModel : BaseViewModel
    {
        int count = 0;
        int calories = 0;
        int km = 0;

        public PedometerViewModel()
        {
            Title = "Pedometer";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public int Count
        {
            get => count;
            set => SetProperty(ref count, value);
        }
        public int Calories
        {
            get => calories;
            set => SetProperty(ref calories, value);
        }
        public int Km
        {
            get => km;
            set => SetProperty(ref km, value);
        }



        public ICommand OpenWebCommand { get; }
    }
}