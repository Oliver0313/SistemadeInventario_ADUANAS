using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Application.DTOs.Factura
{
    internal class FacturaResponseDto
    {
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }
        public string? Descripcion { get; set; }
    }
}
