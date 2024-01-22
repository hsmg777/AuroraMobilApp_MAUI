using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Models
{

    public class Rootcoctail
    {
        public Cocteles[] Property1 { get; set; }
    }

    public class Cocteles
    {
        public string id { get; set; }
        public string title { get; set; }
        public string difficulty { get; set; }
        public string image { get; set; }
    }

}
