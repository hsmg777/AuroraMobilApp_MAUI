using AuroraApp_MAUI.Models;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Bogus;
using PropertyChanged;
using System.ComponentModel;

namespace AuroraApp_MAUI.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ReservasPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Reservas Reservas { get; set; }

        public ICommand SaveCommand { get; }

        public ReservasPageViewModel()
        {
            GenerateNewReserva();

            SaveCommand = new Command(async () =>
            {
                App.reservaRepo.AddorUpdate(Reservas);
                Console.WriteLine("ROW ADDED");
                GenerateNewReserva();
            });
        }

        public void GenerateNewReserva()
        {
            Reservas = new Faker<Reservas>()
                .RuleFor(x => x.nombre, f => f.Person.FullName)
                .RuleFor(x => x.numPersonas, f => f.Person.LastName)
                .RuleFor(x => x.telefono, f => f.Person.Phone)
                .RuleFor(x => x.fecha, f => f.Person.DateOfBirth).Generate();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Reservas)));
        }
    }
}

