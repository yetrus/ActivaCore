using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public class Tipo
    {
        //public Tipo(string descripcion, int idSubTipo )
        //public Tipo(string descripcion)
            public Tipo()
        {
            //   IdTipo = idTipo;
       //     Descripcion = descripcion;
            //IdSubTipo = idSubTipo;
        }

        public int IdTipo { get; set; }
        public string Descripcion { get; set; }
        public int? IdSubTipo { get; set; }

        public virtual ICollection<Entidad> Entidad { get; set; }
    }
}
