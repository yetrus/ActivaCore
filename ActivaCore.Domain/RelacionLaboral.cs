using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class RelacionLaboral
    {
        public int IdRelacionLaboral { get; set; }
        public string RelacionLaboral1 { get; set; }
        public int? IdEstadoRelacionLaboral { get; set; }

        public virtual EstadoRelacionLaboral IdEstadoRelacionLaboralNavigation { get; set; }
    }
}
