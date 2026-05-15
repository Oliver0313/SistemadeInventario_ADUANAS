using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorInventario.Application.Interfaces.Repositories;
using GestorInventario.Domain.Entities;
using GestorInventario.Infrastructure.Persistence;

namespace GestorInventario.Infrastructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task CrearAsync(Domain.Entities.Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task EliminarAsync(Domain.Entities.Categoria categoria)
        {
            throw new NotImplementedException();
        }
        public Task<Domain.Entities.Categoria> ObtenerPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task ActualizarAsync(Domain.Entities.Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> ObtenerTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
