using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Application.DTOs.Proveedor
{
    public class ProveedorResponseDto
    {
        public int Id { get; set; } 
        public string RNC { get; set; }
        public string Nombre { get; set; }
    }
}

