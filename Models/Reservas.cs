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

    public class Reservas
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string nombre { get; set; }
        public string numPersonas { get; set; }
        public string telefono { get; set; }
        public DateTime fecha { get; set; } // Cambiado a DateTime
        public TimeSpan horaLlegada { get; set; }

        public static implicit operator int(Reservas v)
        {
            throw new NotImplementedException();
        }
    }
}
