using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mod5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private async void Exercise01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise01());
        }
        private async void Exercise02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise02());
        }
        private async void Exercise03(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise03());
        }
    }
}
