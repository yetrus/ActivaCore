using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class Producto
    {
        public Producto()
        {
            Detalle = new HashSet<Detalle>();
            ProductoOperacionMap = new HashSet<ProductoOperacionMap>();
        }

        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int? Stock { get; set; }
        public int? StockMin { get; set; }
        public int? StockMax { get; set; }
        public int IdTipo { get; set; }
        public int IdLocal { get; set; }
        public int IdEstado { get; set; }
        public string DescripcionLarga { get; set; }
        public string NombreProducto { get; set; }
        public int? UnidadVenta { get; set; }
        public int? Precio { get; set; }
        public int? Peso { get; set; }
        public int? Largo { get; set; }
        public int? Ancho { get; set; }
        public int? Alto { get; set; }
        public int? Bodega { get; set; }

        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual Local IdLocalNavigation { get; set; }
        public virtual ProductoTipo IdTipoNavigation { get; set; }
        public virtual ICollection<Detalle> Detalle { get; set; }
        public virtual ICollection<ProductoOperacionMap> ProductoOperacionMap { get; set; }
    }
}
