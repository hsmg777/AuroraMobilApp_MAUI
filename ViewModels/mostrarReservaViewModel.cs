using System;
using System.Collections.Generic;
using System.Windows.Input;
using AuroraApp_MAUI.Models;

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
            }
        }

        public ICommand EditCommand => new Command<Reservas>(async (reserva) => await EditReserva(reserva));

        private async Task EditReserva(Reservas reserva)
        {
            if (reserva != null)
            {
                await Shell.Current.GoToAsync($"EditarReservaPage?id={reserva.ID}");
            }
        }


    }

}





