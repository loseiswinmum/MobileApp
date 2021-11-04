using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class Time_reminderViewModel : BaseViewModel
    {
        public Time_reminderViewModel()
        {
            Title = "Time reminder";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}