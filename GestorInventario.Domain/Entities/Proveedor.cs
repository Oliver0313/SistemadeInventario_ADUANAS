using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Domain.Entities
{
    public class Proveedor
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public int Telefono { get; set; }
        public string RNC { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
    }
}
