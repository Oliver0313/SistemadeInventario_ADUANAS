using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorInventario.Application.Interfaces.Repositories;
using GestorInventario.Infrastructure.Persistence;

namespace GestorInventario.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppDbContext _context;
        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task CrearAsync(Domain.Entities.Producto producto)
        {
            throw new NotImplementedException();
        }

        public Task EliminarAsync(Domain.Entities.Producto producto)
        {
            throw new NotImplementedException();
        }

        public Task ActualizarAsync(Domain.Entities.Producto producto)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Producto?> ObtenerPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Domain.Entities.Producto>> ObtenerTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
