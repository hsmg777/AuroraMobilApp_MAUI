// En mostrarReservaViewModel.cs

using AuroraApp_MAUI.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AuroraApp_MAUI.ViewModels
{
    public class mostrarReservaViewModel : INotifyPropertyChanged
    {
        private MostrarReservas _reservationList;

        public MostrarReservas ReservationList
        {
            get { return _reservationList; }
            set
            {
                _reservationList = value;
                OnPropertyChanged(nameof(ReservationList));
            }
        }

        public mostrarReservaViewModel()
        {
            // Inicializa la lista de reservas
            ReservationList = new MostrarReservas();

            // Agrega reservas predeterminadas
            AgregarReservasPredeterminadas();
        }

        private void AgregarReservasPredeterminadas()
        {
            // Crea instancias de Reservas y agrégales valores
            Reservas reserva1 = new Reservas
            {
                nombre = "Jorge Moncayo",
                numPersonas = "4",
                telefono = "0997589387",
                fecha = DateTime.Today.AddDays(1),
                horaLlegada = new TimeSpan(18, 30, 0) // 6:00 PM
            };

            Reservas reserva2 = new Reservas
            {
                nombre = "Hayland Montalvo",
                numPersonas = "6",
                telefono = "0999567465",
                fecha = DateTime.Today.AddDays(2),
                horaLlegada = new TimeSpan(20, 30, 0) // 8:00 PM
            };

            // Agrega las reservas a la lista
            ReservationList.Reservations.Add(reserva1);
            ReservationList.Reservations.Add(reserva2);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}


