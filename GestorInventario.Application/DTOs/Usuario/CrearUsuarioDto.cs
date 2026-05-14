using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Application.DTOs.Usuario
{
    public class CrearUsuarioDto
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string? Rol { get; set; }
    }
}
