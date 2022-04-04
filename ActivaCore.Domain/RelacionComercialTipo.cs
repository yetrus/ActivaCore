using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class RelacionComercialTipo
    {
        public RelacionComercialTipo()
        {
            RelacionComercial = new HashSet<RelacionComercial>();
        }

        public int IdTipoRelacion { get; set; }
        public string TipoRelacion { get; set; }

        public virtual ICollection<RelacionComercial> RelacionComercial { get; set; }
    }
}
