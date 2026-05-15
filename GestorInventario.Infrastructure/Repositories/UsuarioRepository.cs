using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorInventario.Application.Interfaces.Repositories;
using GestorInventario.Infrastructure.Persistence;

namespace GestorInventario.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    
        {
        private readonly AppDbContext _context;
        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task CrearAsync(Domain.Entities.Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task EliminarAsync(Domain.Entities.Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task ActualizarAsync(Domain.Entities.Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Usuario> ObtenerPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Usuario> ObtenerPorCorreoAsync(string correo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Domain.Entities.Usuario>> ObtenerTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
