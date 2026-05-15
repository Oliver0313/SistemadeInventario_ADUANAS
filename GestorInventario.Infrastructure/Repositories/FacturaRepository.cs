using GestorInventario.Application.Interfaces.Repositories;
using GestorInventario.Domain.Entities;
using GestorInventario.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Factura>> ObtenerTodosAsync()
        {
            return await _context.Facturas.ToListAsync();
        }

        public async Task<Factura?> ObtenerPorIdAsync(int id)
        {
            return await _context.Facturas.FindAsync(id);
        }

        public async Task CrearAsync(Factura factura)
        {
            await _context.Facturas.AddAsync(factura);

            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(Factura factura)
        {
            _context.Facturas.Remove(factura);

            await _context.SaveChangesAsync();
        }
    }
}
