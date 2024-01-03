using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using AuroraApp_MAUI.Models;
using Bogus;

namespace AuroraApp_MAUI.ViewModels
{
    public class mostrarReservaViewModel
    {
        public List<Reservas> ReservasList { get; set; }


        public mostrarReservaViewModel() {
            Refresh();
        }
        private void Refresh() {
            ReservasList = App.reservaRepo.GetAll();

        }

       
    }
}



