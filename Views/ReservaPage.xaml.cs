using AuroraApp_MAUI.Models;
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

            // Establecer el contexto de enlace para la vista
            BindingContext = new ReservaPageViewModel();
        }

        private async void BtnReservar_Clicked(object sender, EventArgs e)
        {
            // Verificar si los campos de entrada están vacíos
            if (string.IsNullOrWhiteSpace(entrynombre.Text) || entryFecha.Date == null || entryhora.Time == null ||
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
                // Reserva exitosa, agrega la reserva al ViewModel de MostrarReservas
                if (BindingContext is ReservaPageViewModel reservaPageViewModel)
                {
                    // Obtener la instancia de MostrarReservas del contexto de enlace
                    if (Shell.Current?.CurrentPage?.BindingContext is mostrarReservaViewModel mostrarReservaVM)
                    {
                        mostrarReservaVM.ReservationList.Reservations.Add(reservaPageViewModel.Reservas);
                    }

                    // Restablecer valores después de la reserva exitosa
                    reservaPageViewModel.ResetValues();

                    // Reserva exitosa, muestra un mensaje PERSONALIZADO
                    await DisplayAlert("¡Enhorabuena!", "Tu reserva ha sido confirmada con éxito. ¡Esperamos verte pronto!", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Lo sentimos, la reserva no se pudo completar en este momento. Por favor, inténtalo nuevamente.", "OK");
            }
        }

        private async Task<bool> RealizarReservaAsync()
        {
            // Aquí puedes realizar interacciones con la base de datos o simulaciones
            await Task.Delay(2000);
            // Devolver true para simular una reserva exitosa
            return true;
        }

        private void Regresar_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
        }
    }
}









