using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//Hecho por Antonio Izaguirre (Antoniza) (202010020281)
namespace Ejercicio1_1
{
    public partial class MainPage : ContentPage
    {
        Double numb1, numb2, result;
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddUp()
        {
            numb1 = Convert.ToDouble(num1.Text);
            numb2 = Convert.ToDouble(num2.Text);

            result = numb1 + numb2;
        }

        private void Subtract()
        {
            numb1 = Convert.ToDouble(num1.Text);
            numb2 = Convert.ToDouble(num2.Text);

            result = numb1 - numb2;
        }

        private void Multiply()
        {
            numb1 = Convert.ToDouble(num1.Text);
            numb2 = Convert.ToDouble(num2.Text);

            result = numb1 * numb2;
        }

        private void Divide()
        {
            numb1 = Convert.ToDouble(num1.Text);
            numb2 = Convert.ToDouble(num2.Text);

            result = numb1 / numb2;
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            AddUp();
            await Navigation.PushAsync(new resultPage(result));
        }

        private async void btnSub_Clicked(object sender, EventArgs e)
        {
            Subtract();
            await Navigation.PushAsync(new resultPage(result));
        }

        private async void btnMul_Clicked(object sender, EventArgs e)
        {
            Multiply();
            await Navigation.PushAsync(new resultPage(result));
        }

        private async void btnDiv_Clicked(object sender, EventArgs e)
        {
            Divide();
            await Navigation.PushAsync(new resultPage(result));
        }
    }
}
