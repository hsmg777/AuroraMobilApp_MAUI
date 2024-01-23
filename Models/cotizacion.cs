
using SQLite;

namespace AuroraApp_MAUI.Models
{
    [Table("cotizacion")]
    public class cotizacion
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nombreCoctel { get; set; }
        public string imagen {  get; set; }
        public string nombreReserva { get; set; }
    }
    
}
