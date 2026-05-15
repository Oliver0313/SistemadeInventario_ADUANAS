using GestorInventario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Application.Interfaces.Repositories
{
    public interface IMovimientoInventarioRepository
    {
        Task<IEnumerable<MovimientoInventario>> ObtenerTodosAsync();
        Task<MovimientoInventario?> ObtenerPorIdAsync(int id);
        Task CrearAsync(MovimientoInventario movimiento);
    }
}
