using System;
using System.Collections.Generic;
using AuroraApp_MAUI.Models;

namespace AuroraApp_MAUI.ViewModels
{
    public class mostrarReservaViewModel
    {
        public List<Reservas> ReservasList { get; set; }

        public mostrarReservaViewModel()
        {
            // Agregar dos reservas predeterminadas
            ReservasList = new List<Reservas>
            {

            };
            ReservasList.AddRange(App.reservaRepo.GetAll());
        }
    }
}





