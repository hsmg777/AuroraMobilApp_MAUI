using AuroraApp_MAUI.Models;
using Intents;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraApp_MAUI.Data
{
    class UsuarioData
    {
        private SQLiteAsyncConnection _conexionBD;
        public UsuarioData(SQLiteAsyncConnection conexionBD)
        {
            _conexionBD = conexionBD;
        }
        public Task<List<Usuario>> listaUsuarios() { 
            var lista = _conexionBD
                .Table<Usuario>()
                .ToListAsync();
            return lista;
        }
        public Task<Usuario> ObtenerUsuario(string nombre, string apellido, string NomUsuario, string celular, string contraseña) { 
                var usuario = _conexionBD
                .Table<Usuario>()
                .Where(x=> x.Nombre==nombre && x.Apellido == apellido && x.NomUsuario == NomUsuario && x.Celular == celular && x.Contraseña == contraseña)
                .FirstOrDefaultAsync();
            return usuario;
        }
        public Task<Usuario> ObtenerUsuario(Guid id)
        {
            var usuario = _conexionBD
            .Table<Usuario>()
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync();
            return usuario;
        }
        public async Task<int> SalvaUsuario(Usuario usuario) {
            var usuarioIsSalvo = await ObtenerUsuario(usuario.Id);
            if (usuarioIsSalvo == null)
            {
                return await _conexionBD.InsertAsync(usuario);
            }
            else {
                return await _conexionBD.UpdateAsync(usuario);
            }
        }
        public async Task<int> ExcluiUsuario(Guid id) { 
            return await _conexionBD.DeleteAsync(id);   
        }
        
    }
}
