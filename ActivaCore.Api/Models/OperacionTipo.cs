using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class OperacionTipo
    {
        public OperacionTipo()
        {
            Operacion = new HashSet<Operacion>();
        }

        public int IdOperacionTipo { get; set; }
        public string OperacionTipo1 { get; set; }

        public virtual ICollection<Operacion> Operacion { get; set; }
    }
}
