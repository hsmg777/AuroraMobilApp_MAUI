using AuroraApp_MAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.ViewModels
{
    
    public class ReservaPageViewModel
    {
        public Reservacs Reservacs { get; set; }
        public ReservaPageViewModel() {
            Reservacs = new Reservacs
            {

            };

        }

    }
}
