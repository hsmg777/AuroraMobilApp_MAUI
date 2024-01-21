using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Models
{

    public class RootParty
    {
        public List<Party> Property1 { get; set; }
    }

    public class Party
    {
        public int idFiesta { get; set; }
        public string nombreFiesta { get; set; }
        public string imagen { get; set; }
    }

}
