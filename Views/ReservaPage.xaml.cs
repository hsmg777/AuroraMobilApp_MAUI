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
        }

        private async void BtnReservar_Clicked(object sender, EventArgs e)
        {
            // Mostramos un indicador de carga durante la reserva
            activityIndicator.IsRunning = true;

            // Llamamos al método asíncrono para simular el proceso de reserva
            bool resultadoReserva = await RealizarReservaAsync();

            // Ocultamos el indicador de carga después de la reserva
            activityIndicator.IsRunning = false;

            if (resultadoReserva)
            {
                // Reserva exitosa, muestra un mensaje personalizado
                await DisplayAlert("¡Enhorabuena!", "Tu reserva ha sido confirmada con éxito. ¡Esperamos verte pronto!", "OK");
            }
            else
            {
                // Muestra un mensaje de error
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



