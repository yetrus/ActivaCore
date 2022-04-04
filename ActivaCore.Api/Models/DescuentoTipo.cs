using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class DescuentoTipo
    {
        public DescuentoTipo()
        {
            Descuento = new HashSet<Descuento>();
        }

        public int IdTipo { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Descuento> Descuento { get; set; }
    }
}
