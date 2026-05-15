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
    public class FacturaRepository : IFacturaRepository
    {
        private readonly AppDbContext _context;

        public FacturaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Factura>> ObtenerTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Factura?> ObtenerPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task CrearAsync(Factura factura)
        {
            throw new NotImplementedException();
        }

        public Task EliminarAsync(Factura factura)
        {
            throw new NotImplementedException();
        }
    }
}
