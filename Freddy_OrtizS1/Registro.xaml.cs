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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }
        private void btnOpcion1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Informacion());
           
        }

        private void btnOpcion2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calcular());
        }
    }
}