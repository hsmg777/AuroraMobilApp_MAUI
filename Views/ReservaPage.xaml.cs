
using AuroraApp_MAUI.ViewModels;

namespace AuroraApp_MAUI.Views
{
    public partial class ReservaPage : ContentPage
    {
        private ReservasPageViewModel viewModel;
        public ReservaPage()
        {
            
            InitializeComponent();
            viewModel = new ReservasPageViewModel();
        }
        private void Regresar_Clicked(object sender, EventArgs e)
        {
            
          Shell.Current.GoToAsync("..");
            
        }

        private async  void Reserva_Clicked(object sender, EventArgs e)
        {
            string nombre = entrynombre.Text;
            string telefono = entryTelefono.Text;
            int numeroPersonas = int.Parse(numPersonas.Text);
            DateTime fecha = entryFecha.Date;
            string tiempo = entryhora.Text;

            bool reservaExitosa = await viewModel.CrearReserva(nombre, telefono, numeroPersonas, fecha, tiempo);

            if (reservaExitosa)
            {
                await DisplayAlert("Éxito", "Reserva creada exitosamente", "Aceptar");
            }
            else
            {
                await DisplayAlert("Error", "Hubo un error al realizar la reserva", "Aceptar");
            }
            entrynombre.Text = null;
            entryTelefono.Text = null;
            numPersonas.Text = null;
            entryFecha.Date = DateTime.Now;
            entryhora.Text = null;




        }
    }
}









