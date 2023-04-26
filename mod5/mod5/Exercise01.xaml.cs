using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mod5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise01 : ContentPage
    {
        public Exercise01()
        {
            InitializeComponent();
        }
        private void OnSwitchToggled(object sender, ToggledEventArgs e)
        {
            var switchControl = (Switch)sender;
            var switchLabel = (Label)switchControl.Parent.FindByName("switchLabel");

            if (e.Value)
            {
                switchLabel.Text = "Switch is ON";
            }
            else
            {
                switchLabel.Text = "Switch is OFF";
            }
        }
    }
}