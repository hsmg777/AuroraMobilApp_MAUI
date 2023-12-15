using Microsoft.Maui;
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
                CambiarSourcesDeImagenes();
                labelDatos.Text = "Fiestas actualizadas exitosamente";
                await labelDatos.FadeTo(1, 100);
            }
            else
            {
                labelDatos.Text = "Error al cargar datos. Intenta nuevamente";
            }

            labelDatos.IsEnabled = true;
        }
        private void CambiarSourcesDeImagenes()
        {
            // Nueva URL de la imagen
            string nuevaImagenCasino = "https://i.pinimg.com/564x/35/84/72/358472a84a8801a4c721d3ee48024d59.jpg";
            string nuevaImagenSAVAGE = "https://thumbs.dreamstime.com/z/afiche-de-una-fiesta-en-la-discoteca-con-donuts-dulces-colores-fondo-comida-r%C3%A1pida-basura-ilustraci%C3%B3n-vectorial-191990272.jpg";
            string nuevaImagenZens = "https://i.pinimg.com/474x/9d/eb/3d/9deb3d1bbee696a696cb5581f010c891.jpg";

            // Asignar la nueva fuente a la imagen
            Casino.Source = ImageSource.FromUri(new Uri(nuevaImagenCasino));
            SAVAGE.Source = ImageSource.FromUri(new Uri(nuevaImagenSAVAGE));
            Zens.Source = ImageSource.FromUri(new Uri(nuevaImagenZens));

            Casino.WidthRequest = 210;
            Casino.HeightRequest = 280;
            Casino.Aspect = Aspect.AspectFill; 
            SAVAGE.WidthRequest = 210;
            SAVAGE.HeightRequest = 280;
            SAVAGE.Aspect = Aspect.AspectFill;
            Zens.WidthRequest = 210;
            Zens.HeightRequest = 280;
            Zens.Aspect = Aspect.AspectFill;
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
