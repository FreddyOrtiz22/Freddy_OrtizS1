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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "uisrael";
            string contraseña = "2023";

            if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
            {
                Navigation.PushAsync(new Registro());
            }
            else
            {
                DisplayAlert("Aceptar", "Usuario o contraseña incorrecta", "cerrar");
            }
        }



    }
}