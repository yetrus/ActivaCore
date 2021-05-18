using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class Descuento
    {
        public int IdDescuento { get; set; }
        public int? IdTipo { get; set; }
        public int? Descuento1 { get; set; }

        public virtual DescuentoTipo IdTipoNavigation { get; set; }
    }
}
