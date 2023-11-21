using AuroraApp_MAUI.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Data
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _conexionBD;
        //public UsuarioData UsuarioDataTable {  get; set; }
        public SQLiteData(string path) {
            _conexionBD = new SQLiteAsyncConnection(path);
            _conexionBD.CreateTableAsync<Usuario>().Wait();

        }    
    }
}
