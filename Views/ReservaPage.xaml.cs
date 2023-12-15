using AuroraApp_MAUI.ViewModels;
using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Views
{
    public partial class ReservaPage : ContentPage
    {
        public ReservaPage()
        {
            InitializeComponent();
            BindingContext = new ReservaPageViewModel();
        }

        private async void BtnReservar_Clicked(object sender, EventArgs e)
        {
            // Verificar si los campos de entrada están vacíos
            if (string.IsNullOrWhiteSpace(entrynombre.Text) ||
                entryFecha == null ||
                entryhora == null ||
                string.IsNullOrWhiteSpace(numPersonas.Text))
            {
                
                await DisplayAlert("Error", "Por favor, completa todos los campos antes de reservar.", "OK");
                return;
            }
            activityIndicator.IsRunning = true;

            bool resultadoReserva = await RealizarReservaAsync();
            activityIndicator.IsRunning = false;

            if (resultadoReserva)
            {
                // Reserva exitosa, muestra un mensaje PERSONALIZADO
                await DisplayAlert("¡Enhorabuena!", "Tu reserva ha sido confirmada con éxito. ¡Esperamos verte pronto!", "OK");
            }
            else
            {
                await DisplayAlert("Error", "Lo sentimos, la reserva no se pudo completar en este momento. Por favor, inténtalo nuevamente.", "OK");
            }
        }

        private async Task<bool> RealizarReservaAsync()
        {
            bool reservaExitosa = SimularInteraccionBaseDatos();

            await Task.Delay(2000);

            return reservaExitosa;
        }

        private void Regresar_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
        }

        private bool SimularInteraccionBaseDatos()
        {
            Random random = new Random();
            return random.NextDouble() < 0.8;
        }
    }
}




