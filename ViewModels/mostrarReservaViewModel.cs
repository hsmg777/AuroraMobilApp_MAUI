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
                new Reservas
                {
                    nombre = "Jorge Moncayo",
                    numPersonas = "5",
                    telefono = "0997589387",
                    fecha = DateTime.Now.AddDays(1),
                    horaLlegada = new TimeSpan(18, 0, 0) // 6:00 PM
                },
                new Reservas
                {
                    nombre = "Hayland Montalvo 2",
                    numPersonas = "3",
                    telefono = "0999567465",
                    fecha = DateTime.Now.AddDays(2),
                    horaLlegada = new TimeSpan(20, 0, 0) // 8:00 PM
                }
            };
            ReservasList.AddRange(App.reservaRepo.GetAll());
        }
    }
}





