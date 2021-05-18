using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class Servicio
    {
        public Servicio()
        {
            Operacion = new HashSet<Operacion>();
        }

        public int IdServicio { get; set; }
        public string Descripcion { get; set; }
        public int IdTipo { get; set; }
        public int? IdEstado { get; set; }

        public virtual ICollection<Operacion> Operacion { get; set; }
    }
}
