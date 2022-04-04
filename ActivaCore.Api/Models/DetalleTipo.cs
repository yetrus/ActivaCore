using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class DetalleTipo
    {
        public DetalleTipo()
        {
            Detalle = new HashSet<Detalle>();
        }

        public int IdTipo { get; set; }
        public string TipoDescripcion { get; set; }

        public virtual ICollection<Detalle> Detalle { get; set; }
    }
}
