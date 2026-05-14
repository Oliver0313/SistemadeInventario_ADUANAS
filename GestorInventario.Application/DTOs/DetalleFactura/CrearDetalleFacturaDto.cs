using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Application.DTOs.DetalleFactura
{
    public class CrearDetalleFacturaDto
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
    }
}
