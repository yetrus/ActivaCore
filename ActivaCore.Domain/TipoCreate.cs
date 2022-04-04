using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public class TipoCreate
    {
        public TipoCreate(string descripcion, int? idSubTipo)
        {
            Descripcion = descripcion;
            IdSubTipo = idSubTipo;
        }

        public int IdTipo { get; set; }
        public string Descripcion { get; set; }
        public int? IdSubTipo { get; set; }

       // public virtual ICollection<Entidad> Entidad { get; set; }
    }
}
