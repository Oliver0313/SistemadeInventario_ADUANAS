using GestorInventario.Application.Interfaces.Repositories;
using GestorInventario.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppDbContext _context;
        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CrearAsync(Domain.Entities.Producto producto)
        {
            await _context.Productos.AddAsync(producto);

            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(Domain.Entities.Producto producto)
        {
            _context.Productos.Remove(producto);

            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Domain.Entities.Producto producto)
        {
            _context.Productos.Update(producto);

            await _context.SaveChangesAsync();
        }

        public async Task<Domain.Entities.Producto?> ObtenerPorIdAsync(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task<IEnumerable<Domain.Entities.Producto>> ObtenerTodosAsync()
        {
            return await _context.Productos.ToListAsync();
        }
    }
}
