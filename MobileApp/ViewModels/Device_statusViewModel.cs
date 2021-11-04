using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class Device_statusViewModel : BaseViewModel
    {
        public Device_statusViewModel()
        {
            Title = "Device status";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}