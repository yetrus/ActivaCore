using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class ImpuestoTipo
    {
        public ImpuestoTipo()
        {
            Impuesto = new HashSet<Impuesto>();
        }

        public int IdTipoImpuesto { get; set; }
        public string TipoImpuesto { get; set; }

        public virtual ICollection<Impuesto> Impuesto { get; set; }
    }
}
