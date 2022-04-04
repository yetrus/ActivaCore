using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class ProductoTipo
    {
        public ProductoTipo()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdTipo { get; set; }
        public string TipoDescripcion { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
