using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Application.DTOs.Usuario
{
    public class CambiarPasswordDto
    {
        public string ContraseñaActual { get; set; }
        public string NuevaContraseña { get; set; }
    }
}
