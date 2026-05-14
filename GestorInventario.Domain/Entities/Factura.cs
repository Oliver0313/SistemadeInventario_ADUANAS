using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Domain.Entities
{
    public class Factura
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public string? Descripcion { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
