using AuroraApp_MAUI.Models;

using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Repositories
{
    public class cotizacionRepository
    {
        SQLiteConnection connection;
        public string StatusMessagge { get; set; }
        public cotizacionRepository() {
            connection =
                new SQLiteConnection(Constants.DatabasePath,
                Constants.Flags);
            connection.CreateTable<cotizacion>();

        }
        public void AddorUpdate(cotizacion Cotizacion) {
            int result = 0;
            try
            {
                if (Cotizacion.Id != 0) {
                    result = connection.Update(Cotizacion);
                    StatusMessagge=
                        $"{result} row(s) updated";
                }
                else
                {
                    result = connection.Insert(Cotizacion);
                    StatusMessagge =
                        $"{result} row(s) addded";
                }
                
                
            }
            catch (Exception ex) {
                StatusMessagge = $"ERROR {ex.Message}";

            }
            
        }

        public List<cotizacion> GetAll()
        {
            try {
                return connection.Table<cotizacion>().ToList();
            } catch (Exception ex) {
                StatusMessagge = $"ERROR {ex.Message}";
            }
            return null;
        }

        public cotizacion Get(int id) {
            try {
                return connection.Table<cotizacion>().FirstOrDefault(x => x.Id == id);
            } catch (Exception ex)
            {
                StatusMessagge = $"ERROR {ex.Message}";
            }
            return null;
        }

        public void Delete(int cotizacionId) {
            try {
                var coti =
                    Get(cotizacionId);
                connection.Delete(coti);
            } catch (Exception ex)
            {
                StatusMessagge = $"ERROR {ex.Message}";
            }
        }
    }
}
