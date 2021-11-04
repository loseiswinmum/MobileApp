using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Time_reminder : ContentPage
    {
        public Time_reminder()
        {
            InitializeComponent();
        }
        public void reminder(object sender, EventArgs e)
        {
            var nowtime = DateTime.Now.ToString("hh:mm:ss");
            string remind_time = (hour.Text +":"+ minute.Text +":"+ second.Text);

            if(nowtime = reminder)
            {
                CrossLocalNotifications.Current.Show("APP", "Is time.", 0);
            }

        }
    }
}