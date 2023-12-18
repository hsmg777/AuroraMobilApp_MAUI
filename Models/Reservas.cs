using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Models
{
    public class Reservas
    {
        public string nombre { get; set; }
        public string numPersonas { get; set; }
        public string telefono { get; set; }
        public DateTime fecha { get; set; } // Cambiado a DateTime
        public TimeSpan horaLlegada { get; set; }
    }
}
