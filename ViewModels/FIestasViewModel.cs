using AuroraApp_MAUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.ViewModels
{
     
    public class FIestasViewModel : BaseModel2
    {
        private ObservableCollection<Party> _reservas;

        public ObservableCollection<Party> Reservas
        {
            get => _reservas;
            set => SetProperty(ref _reservas, value);
        }

        public FIestasViewModel()
        {
            LoadPartysAsync(); // Llama automáticamente al cargar el ViewModel
        }

        public async Task LoadPartysAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "https://localhost:7051/api/Fiestas";

                    var response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonContent = await response.Content.ReadAsStringAsync();
                        var reservasList = JsonConvert.DeserializeObject<List<Party>>(jsonContent);
                        Reservas = new ObservableCollection<Party>(reservasList);
                    }
                    else
                    {
                        Console.WriteLine("Error al obtener las fiestas. Código de estado: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}
