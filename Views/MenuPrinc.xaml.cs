using AuroraApp_MAUI.Models;
using AuroraApp_MAUI.ViewModels;
using Microsoft.Maui;
using Newtonsoft.Json;
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

       

        private void Regresar_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
        }

        private void verReservas_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(mostrarReservas));
        }

        private async void Actualizar_Clicked(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = "https://localhost:7051/api/Fiestas";
                var response = await client.GetStringAsync(url);

                var fiestas = JsonConvert.DeserializeObject<List<Party>>(response);

                var ultimasFiestas = fiestas.OrderByDescending(f => f.idFiesta).Take(3).ToList();

                for (int i = 0; i < ultimasFiestas.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Fiesta1.Text = ultimasFiestas[i].nombreFiesta;
                           
                            imagen1.Source = ultimasFiestas[i].imagen;
                            break;
                        case 1:
                            Fiesta2.Text = ultimasFiestas[i].nombreFiesta;
                            
                            imagen2.Source = ultimasFiestas[i].imagen;
                            break;
                        case 2:
                            Fiesta3.Text = ultimasFiestas[i].nombreFiesta;
                           
                            imagen3.Source = ultimasFiestas[i].imagen;
                            break;
                    }
                }

                labelDatos.Text = "Fiestas actualizadas correctamente";
            }
            catch (Exception ex)
            {
                labelDatos.Text = $"Error al actualizar las fiestas: {ex.Message}";
            }

        }

        private void Reservar_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ReservaPage));
        }

        private void cocteles_Cliked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(MenuCocteles));
        }
    }

}
