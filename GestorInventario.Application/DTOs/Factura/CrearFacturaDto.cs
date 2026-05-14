using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Application.DTOs.Factura
{
    public class CrearFacturaDto
    {
        public DateTime Fecha { get; set; }    
        public int UsuarioId { get; set; }
        public string? Descripcion { get; set; }
    }
}


