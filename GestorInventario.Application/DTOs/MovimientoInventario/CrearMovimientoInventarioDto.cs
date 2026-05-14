using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorInventario.Domain.Enums;

namespace GestorInventario.Application.DTOs.MovimientoInventario
{
    public class CrearMovimientoInventarioDto
    {
        public int ProductoId { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
    }
}
