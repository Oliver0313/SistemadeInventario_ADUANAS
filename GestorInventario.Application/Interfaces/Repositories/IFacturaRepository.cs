using GestorInventario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Application.Interfaces.Repositories
{
    public interface IFacturaRepository
    {
        Task<IEnumerable<Factura>> ObtenerTodosAsync();
        Task<Factura?> ObtenerPorIdAsync(int id);
        Task CrearAsync(Factura factura);
        Task EliminarAsync(Factura factura);
    }
}
