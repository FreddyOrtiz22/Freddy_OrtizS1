using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Freddy_OrtizS1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calcular : ContentPage
    {
        public Calcular()
        {
            InitializeComponent();
            
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            string fechaNacimientoStr = txtFechaNacimiento.Text;

            DateTime fechaNacimiento;
            if (!DateTime.TryParse(fechaNacimientoStr, out fechaNacimiento))
            {
                DisplayAlert("Error", "Fecha de nacimiento inválida. Inténtelo nuevamente.", "OK");
                return;
            }

            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Comprobamos si el cumpleaños de este año ya ha pasado
            if (fechaActual < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            lblEdad.Text = "Su edad es: " + edad;
        }




    }
}