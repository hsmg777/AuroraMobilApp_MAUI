using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Models
{
    public class MostrarReservas
    {
        public ObservableCollection<Reservacs> Reservations { get; set; }

        public MostrarReservas()
        {
            Reservations = new ObservableCollection<Reservacs>();
        }
    }
        
}
