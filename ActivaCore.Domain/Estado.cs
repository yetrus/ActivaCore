using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class Estado
    {
        public Estado()
        {
            Categoria = new HashSet<Categoria>();
            Detalle = new HashSet<Detalle>();
            Documento = new HashSet<Documento>();
            Entidad = new HashSet<Entidad>();
            Operacion = new HashSet<Operacion>();
            Producto = new HashSet<Producto>();
            RelacionComercial = new HashSet<RelacionComercial>();
        }

        public int IdEstado { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Categoria> Categoria { get; set; }
        public virtual ICollection<Detalle> Detalle { get; set; }
        public virtual ICollection<Documento> Documento { get; set; }
        public virtual ICollection<Entidad> Entidad { get; set; }
        public virtual ICollection<Operacion> Operacion { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
        public virtual ICollection<RelacionComercial> RelacionComercial { get; set; }
    }
}
