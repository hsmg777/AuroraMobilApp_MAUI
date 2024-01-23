using AuroraApp_MAUI.Views;
using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;


namespace AuroraApp_MAUI.Views
{
    public partial class IniciarSesion : ContentPage
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private async void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            // Mostramos un indicador de carga durante el inicio de sesión
            activityIndicator.IsRunning = true;

            bool resultadoInicioSesion = await RealizarInicioSesionAsync();

            // Ocultamos el indicador de carga después del inicio de sesión
            activityIndicator.IsRunning = false;

            if (resultadoInicioSesion)
            {
                await Shell.Current.GoToAsync(nameof(MenuPrinc));
            }
            else
            {
                await DisplayAlert("Error", "Inicio de sesión fallido", "OK");
            }
        }

        private async Task<bool> RealizarInicioSesionAsync()
        {
            string usuario = lblUsuario.Text;
            string contraseña = lblContraseña.Text;
            bool result = false;
            result =  App.userRepo.VerificarCredenciales(usuario, contraseña);
            if (result) { 
            return true;
            } 
            return false;
        }

        private async void Regresar_Clicked(object sender, EventArgs e)
        {
            // Mostramos un indicador de carga durante el regreso
            activityIndicator.IsRunning = true;
            await Shell.Current.GoToAsync("..");
            activityIndicator.IsRunning = false;
        }
    }
}

