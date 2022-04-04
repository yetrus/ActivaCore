using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class Operacion
    {
        public Operacion()
        {
            ProductoOperacionMap = new HashSet<ProductoOperacionMap>();
        }

        public int IdOperacion { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdDoc { get; set; }
        public int IdEntidadOrigen { get; set; }
        public int IdServicio { get; set; }
        public int IdTipo { get; set; }
        public int IdEstado { get; set; }
        public int IdEntidadDestino { get; set; }

        public virtual Documento IdDocNavigation { get; set; }
        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual Servicio IdServicioNavigation { get; set; }
        public virtual OperacionTipo IdTipoNavigation { get; set; }
        public virtual ICollection<ProductoOperacionMap> ProductoOperacionMap { get; set; }
    }
}
