using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Homework_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var buttonText = (sender as Button).Text;
            if (buttonText != "C") {
                labelResult.Text = labelResult.Text + buttonText;
            }
            else
            {
                labelResult.Text = "";
            }
        }
    }
}
