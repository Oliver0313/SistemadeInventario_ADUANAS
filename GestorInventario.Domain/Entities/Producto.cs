using GestorInventario.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string? Descripcion { get; set; }

        public int Codigo { get; set; }

        public int CategoriaId { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public int ProveedorId { get; set; }

        public int StockMinimo { get; set; }

        public UnidadMedida Unidad { get; set; }
    }
}
