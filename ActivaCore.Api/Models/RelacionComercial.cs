using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class RelacionComercial
    {
        public int IdRelacionComercial { get; set; }
        public int? IdTipoRelacion { get; set; }
        public int? IdEstado { get; set; }

        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual RelacionComercialTipo IdTipoRelacionNavigation { get; set; }
    }
}
