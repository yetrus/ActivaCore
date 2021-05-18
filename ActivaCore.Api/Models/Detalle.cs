using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class Detalle
    {
        public int IdDetalle { get; set; }
        public int? Cantidad { get; set; }
        public int IdDoc { get; set; }
        public int IdEstado { get; set; }
        public int IdEntidad { get; set; }
        public int IdProducto { get; set; }
        public int IdTipo { get; set; }
        public int IdCategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Documento IdDocNavigation { get; set; }
        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
        public virtual DetalleTipo IdTipoNavigation { get; set; }
    }
}
