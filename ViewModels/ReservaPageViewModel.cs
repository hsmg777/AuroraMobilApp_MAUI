using AuroraApp_MAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.ViewModels
{
    public class ReservaPageViewModel
    {
        public Reservas Reservas { get; set; }

        public ReservaPageViewModel()
        {
            Reservas = new Reservas();
            Reservas.nombre = "Nombres y Apellidos*";
            Reservas.telefono = "099123456*";
            Reservas.numPersonas = "0*";

            // Inicializar fecha y horaLlegada con valores predeterminados
            Reservas.fecha = DateTime.Today; // Puedes cambiar esto según tus necesidades
            Reservas.horaLlegada = new TimeSpan(12, 0, 0); // Por ejemplo, 12:00 PM
        }

        public void ResetValues()
        {
            Reservas.nombre = null;
            Reservas.telefono = null;
            Reservas.numPersonas = null;

            // Restablecer fecha y horaLlegada con valores predeterminados
            Reservas.fecha = DateTime.Today;
            Reservas.horaLlegada = new TimeSpan(12, 0, 0);
        }
    }

}
