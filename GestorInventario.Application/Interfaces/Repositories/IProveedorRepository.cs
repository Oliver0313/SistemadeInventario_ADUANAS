using GestorInventario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Application.Interfaces.Repositories
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<Proveedor>> ObtenerTodosAsync();
        public Task<Proveedor> ObtenerPorIdAsync(int id);
        public Task CrearAsync(Proveedor proveedor);
        public Task ActualizarAsync(Proveedor proveedor);
        public Task EliminarAsync(Proveedor proveedor);
    }
}
