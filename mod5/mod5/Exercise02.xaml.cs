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
    public partial class Exercise02 : ContentPage
    {
        public Exercise02()
        {
            InitializeComponent();
        }
        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            var stepperControl = (Stepper)sender;
            var quantityLabel = (Label)stepperControl.Parent.FindByName("quantityLabel");

            quantityLabel.Text = e.NewValue.ToString();
        }
    }
}