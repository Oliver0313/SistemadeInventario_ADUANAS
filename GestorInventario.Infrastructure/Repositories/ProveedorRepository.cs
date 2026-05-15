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
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly AppDbContext _context;

        public ProveedorRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<Proveedor> ObtenerPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Crear(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public Task Actualizar(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public Task Eliminar(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Proveedor>> ObtenerTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
