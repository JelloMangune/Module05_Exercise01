using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mod5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise03 : ContentPage
    {
        public Exercise03()
        {
            InitializeComponent();
        }
        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            var datePicker = (DatePicker)sender;
            var selectedDate = e.NewDate;

            // Do something with the selected date
        }

        private void OnTimeSelected(object sender, PropertyChangedEventArgs e)
        {
            var timePicker = (TimePicker)sender;
            var selectedTime = timePicker.Time;

            // Do something with the selected time
        }
    }
}