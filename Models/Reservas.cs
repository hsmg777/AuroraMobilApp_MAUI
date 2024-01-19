using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColumnAttribute = SQLite.ColumnAttribute;
using TableAttribute = SQLite.TableAttribute;

namespace AuroraApp_MAUI.Models
{
    public class Rootobject
    {
        public int idReserva { get; set; }
        public string nombre { get; set; }
        public int numeroPersonas { get; set; }
        public string telefono { get; set; }
        public DateTime fecha { get; set; }
        public string horaLlega { get; set; }
    }
}
