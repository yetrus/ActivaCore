using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class ProductoOperacionMap
    {
        public int IdProducto { get; set; }
        public int IdOperacion { get; set; }

        public virtual Operacion IdOperacionNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
