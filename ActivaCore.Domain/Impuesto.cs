using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class Impuesto
    {
        public int IdImpuesto { get; set; }
        public int? Descripcion { get; set; }
        public string NombreImpuesto { get; set; }
        public int? IdTipo { get; set; }

        public virtual ImpuestoTipo IdTipoNavigation { get; set; }
    }
}
