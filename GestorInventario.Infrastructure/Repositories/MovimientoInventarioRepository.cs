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
    public class MovimientoInventarioRepository : IMovimientoInventarioRepository
    {
        private readonly AppDbContext _context;

        public MovimientoInventarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CrearAsync(Domain.Entities.MovimientoInventario movimientoInventario)
        {
            await _context.MovimientosInventario.AddAsync(movimientoInventario);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.MovimientoInventario>> ObtenerTodosAsync()
        {
            return await _context.MovimientosInventario.ToListAsync();
        }

        public async Task<Domain.Entities.MovimientoInventario?> ObtenerPorIdAsync(int id)
        {
            return await _context.MovimientosInventario.FindAsync(id);
        }
    }
}
