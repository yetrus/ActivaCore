using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class Tipo
    {
        public Tipo()
        {
            Entidad = new HashSet<Entidad>();
        }

        public int IdTipo { get; set; }
        public string Descripcion { get; set; }
        public int? IdSubTipo { get; set; }

        public virtual ICollection<Entidad> Entidad { get; set; }
    }
}
