using AuroraApp_MAUI.Models;
using AuroraApp_MAUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.ViewModels
{
    public class mostrarReservaViewModel
    {
        public mostrarReservas ReservationList { get; set; }

        public mostrarReservaViewModel()
        {
            ReservationList = new mostrarReservas();
        }
        

    }
}
