using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class Local
    {
        public Local()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdLocal { get; set; }
        public string Descripcion { get; set; }
        public int IdLocalTipo { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
