using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Models
{
    class Usuario
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        [DisplayName("Nombre de Usuario")]
        public string NomUsuario {  get; set; }

        [StringLength(10)]
        public string Celular { get; set; }

        public string Contraseña { get; set; }
    }
}
