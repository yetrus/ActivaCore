using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class Documento
    {
        public Documento()
        {
            Detalle = new HashSet<Detalle>();
            Operacion = new HashSet<Operacion>();
        }

        public int IdDoc { get; set; }
        public int? Numero { get; set; }
        public DateTime? FechaDoc { get; set; }
        public int? Neto { get; set; }
        public int? SubDoc { get; set; }
        public int IdEstado { get; set; }
        public int IdTipo { get; set; }
        public int? Total { get; set; }

        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual DocumentoTipo IdTipoNavigation { get; set; }
        public virtual ICollection<Detalle> Detalle { get; set; }
        public virtual ICollection<Operacion> Operacion { get; set; }
    }
}
