using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Detalle = new HashSet<Detalle>();
            Entidad = new HashSet<Entidad>();
        }

        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public int? SubCat { get; set; }
        public int? IdEstado { get; set; }

        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual ICollection<Detalle> Detalle { get; set; }
        public virtual ICollection<Entidad> Entidad { get; set; }
    }
}
