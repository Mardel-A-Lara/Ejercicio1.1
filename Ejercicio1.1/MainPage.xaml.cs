using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            var rsuma = Convert.ToDouble(numero1.Text) + Convert.ToDouble(numero2.Text);

            DisplayAlert("Aviso", "El resultado es " + rsuma.ToString(), "OK");

        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            var rresta = Convert.ToDouble(numero1.Text) - Convert.ToDouble(numero2.Text);

            DisplayAlert("Aviso", "El resultado es " + rresta.ToString(), "OK");
        }

        private async void btndivision_Clicked(object sender, EventArgs e)
        {
            var rdivision = Convert.ToDouble(numero1.Text) / Convert.ToDouble(numero2.Text);

            DisplayAlert("Aviso", "El resultado es " + rdivision.ToString(), "OK");
        }

        private async void Multiplicacion_Clicked(object sender, EventArgs e)
        {
            var rmultiplicacion = Convert.ToDouble(numero1.Text) * Convert.ToDouble(numero2.Text);

            DisplayAlert("Aviso", "El resultado es " + rmultiplicacion.ToString(), "OK");
        }
    }
}
