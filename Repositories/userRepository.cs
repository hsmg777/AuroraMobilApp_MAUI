using AuroraApp_MAUI.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Repositories
{
    public class userRepository
    {
        SQLiteConnection connection;
        public string StatusMessagge { get; set; }
        public userRepository()
        {
            connection =
                new SQLiteConnection(Constants.DatabasePath,
                Constants.Flags);
            connection.CreateTable<user>();

        }

       
        public void Add(user newUser)
        {
            int result = 0;
            try
            {
                result = connection.Insert(newUser);
                StatusMessagge =
                    $"{result} row(s) addded";
            }
            catch (Exception ex)
            {
                StatusMessagge = $"ERROR {ex.Message}";

            }

        }
        
        public user Get(string username)
        {
            try
            {
                return connection.Table<user>().FirstOrDefault(x => x.usuario == username);
            }
            catch (Exception ex)
            {
                StatusMessagge = $"ERROR {ex.Message}";
            }
            return null;
        }

        public bool VerificarCredenciales(string username, string password)
        {
            user usuario = Get(username);

            if (usuario != null)
            {
                if (usuario.contraseña == password)
                {
                    
                    return true;
                }
            }

            return false;
        }


    }

    
    
}
