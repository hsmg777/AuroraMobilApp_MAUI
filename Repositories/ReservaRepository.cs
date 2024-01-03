using AuroraApp_MAUI.Models;

using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Repositories
{
    public class ReservaRepository
    {
        SQLiteConnection connection;
        public string statusMessagge {  get; set; }
        public ReservaRepository() {
            connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
            connection.CreateTable<Reservas>();
            
        }
        public void AddorUpdate(Reservas reservas)
        {

            int result = 0;
            try {
                if (reservas.ID != 0)
                {
                    result = connection.Update(reservas);
                    statusMessagge = $"{result} row(s) updated";
                }
                else {
                    result = connection.Insert(reservas);
                    statusMessagge = $"{result} row(s) added";
                }
                
            } catch (Exception ex) {
                statusMessagge =
                   $"Error:{ex.Message}";
            }
        }
        public List<Reservas> GetAll() {
            try {
                return connection.Table<Reservas>().ToList();
            }
            catch (Exception ex) {
                statusMessagge =
                   $"Error:{ex.Message}";
            }
            return null;
        }
        public Reservas Get(int id) {
            try {
                return 
                    connection.Table<Reservas>().FirstOrDefault(x => x.ID == id);
            } catch (Exception ex)
            {
                statusMessagge =
                                   $"Error:{ex.Message}";
            }
            return null;
        }
        public void Delete(int reservaId)
        {
            try
            {
                var Reserva =
                    Get(reservaId);
                connection.Delete(reservaId);
            }catch (Exception ex)
            {
                statusMessagge =
                   $"Error:{ex.Message}";
            }
        }
        
    }
}
