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
        public Task Crear(Proveedor proveedor);
        public Task Actualizar(Proveedor proveedor);
        public Task Eliminar(Proveedor proveedor);
    }
}
