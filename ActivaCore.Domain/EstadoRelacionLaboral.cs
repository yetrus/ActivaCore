using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class EstadoRelacionLaboral
    {
        public EstadoRelacionLaboral()
        {
            RelacionLaboral = new HashSet<RelacionLaboral>();
        }

        public int IdEstadoRelacionLaboral { get; set; }
        public string EstadoRelacionLaboral1 { get; set; }

        public virtual ICollection<RelacionLaboral> RelacionLaboral { get; set; }
    }
}
