using GestorInventario.Application.Interfaces.Repositories;
using GestorInventario.Domain.Entities;
using GestorInventario.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Infrastructure.Repositories
{
    internal class MovimientoInventarioRepository : IMovimientoInventarioRepository
    {
        private readonly AppDbContext _context;

        public MovimientoInventarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task CrearAsync(Domain.Entities.MovimientoInventario producto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Domain.Entities.MovimientoInventario>> ObtenerTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.MovimientoInventario?> ObtenerPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
