using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//Hecho por Antonio Izaguirre (Antoniza) (202010020281)
namespace Ejercicio1_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class resultPage : ContentPage
    {
        public resultPage(Double result)
        {
            InitializeComponent();
            txtResult.Text = result.ToString();
        }
    }
}