using System;
using System.Collections.Generic;
using System.Windows.Input;
using AuroraApp_MAUI.Models;
using AuroraApp_MAUI.Views;

namespace AuroraApp_MAUI.ViewModels
{
    public class verCoctelesViewModel
    {
        public List<cotizacion> cotiList { get; set; }

        public verCoctelesViewModel()
        {
            // Agregar dos reservas predeterminadas
            cotiList = new List<cotizacion>();
            cotiList.AddRange(App.cotiRepo.GetAll());
        }

        public ICommand DeleteCommand => new Command<cotizacion>(async (cotita) => await DeleteReserva(cotita));

        private async Task DeleteReserva(cotizacion cotita)
        {
            if (cotita != null)
            {
                App.cotiRepo.Delete(cotita.Id);
                cotiList.Remove(cotita);
                await Shell.Current.DisplayAlert("Éxito", "Reserva eliminada con éxito", "OK");
                await Shell.Current.GoToAsync(nameof(MenuPrinc));

            }
        }



    }

}