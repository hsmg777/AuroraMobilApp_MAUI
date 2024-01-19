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
using Newtonsoft.Json;

namespace AuroraApp_MAUI.ViewModels
{
    
    public class ReservasPageViewModel 
    {
        public async Task<bool> CrearReserva(string nombre, string telefono, int numeroPersonas, DateTime fecha, string tiempo)
        {
            Rootobject reserva = new Rootobject
            {
                nombre = nombre,
                telefono = telefono,
                numeroPersonas = numeroPersonas,
                fecha = fecha,
                horaLlega = tiempo
            };

            string jsonReserva = JsonConvert.SerializeObject(reserva);

            string apiUrl = "https://localhost:7051/api/Reservas";
            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(jsonReserva, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

            return response.IsSuccessStatusCode;
        }
    }
}

