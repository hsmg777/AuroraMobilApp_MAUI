using System;
using System.Threading.Tasks;


namespace AuroraApp_MAUI.Views
{
    public partial class MenuPrinc : ContentPage
    {
        public MenuPrinc()
        {
            InitializeComponent();
        }

        private async void LabelDatos_Tapped(object sender, EventArgs e)
        {
            labelDatos.IsEnabled = false;
            bool resultadoCargaDatos = await CargarDatosAsync();

            if (resultadoCargaDatos)
            {
                await labelDatos.FadeTo(0, 100);
                labelDatos.Text = "Fiestas actualizadas exitosamente";
                await labelDatos.FadeTo(1, 100);
            }
            else
            {
                labelDatos.Text = "Error al cargar datos. Intenta nuevamente";
            }

            labelDatos.IsEnabled = true;
        }

        private async Task<bool> CargarDatosAsync()
        {
            try
            {
                await Task.Delay(3000);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error durante la carga de datos: {ex.Message}");
                return false;
            }
        }

        private void Reservar_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ReservaPage));
        }
        private void Regresar_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
        }
    }
}
