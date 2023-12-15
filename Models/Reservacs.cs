using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Models
{
    public class Reservacs
    {
        public string nombre { get; set; }
        public string numPersonas { get; set; }
        public string telefono { get; set; }
        public DatePicker fecha { get; set; }
        public TimePicker horaLlegada { get; set; }

    }
}
