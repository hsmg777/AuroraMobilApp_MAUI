using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Models
{
    [Table("user")]
    public class user
    {
        [PrimaryKey, AutoIncrement]
        public int id {  get; set; }
        public string usuario { get; set; }
        public string contraseña {  get; set; }
    }
}
