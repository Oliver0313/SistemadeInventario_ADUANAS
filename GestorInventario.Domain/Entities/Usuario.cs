using GestorInventario.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }  

        public string Correo { get; set; }

        public TipoUsuario TipoUsuario { get; set; }
    }
}
