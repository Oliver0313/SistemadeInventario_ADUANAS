using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorInventario.Domain.Enums;

namespace GestorInventario.Domain.Entities
{
    public class MovimientoInventario
    {
        public int Id { get; set; }

        public int Usuarioid { get; set; }

        public TipoMovimiento TipoMovimiento { get; set; }

        public DateTime Fecha { get; set; }

        public int Cantidad { get; set; }

        public int ProductoId { get; set; }
    }
}
