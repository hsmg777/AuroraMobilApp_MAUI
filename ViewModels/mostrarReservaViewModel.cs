using System;
using System.Collections.Generic;
using System.Windows.Input;
using AuroraApp_MAUI.Models;
using AuroraApp_MAUI.Views;

namespace AuroraApp_MAUI.ViewModels
{
    public class mostrarReservaViewModel
    {
        public List<Reservas> ReservasList { get; set; }

        public mostrarReservaViewModel()
        {
            // Agregar dos reservas predeterminadas
            ReservasList = new List<Reservas>();
            ReservasList.AddRange(App.reservaRepo.GetAll());
        }

        public ICommand DeleteCommand => new Command<Reservas>(async (reserva) => await DeleteReserva(reserva));

        private async Task DeleteReserva(Reservas reserva)
        {
            if (reserva != null)
            {
                App.reservaRepo.Delete(reserva.ID);
                ReservasList.Remove(reserva);
                await Shell.Current.DisplayAlert("Éxito", "Reserva eliminada con éxito", "OK");
                await Shell.Current.GoToAsync(nameof(MenuPrinc));

            }
        }



    }

}





