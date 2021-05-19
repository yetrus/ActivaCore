using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class Archivo
    {
        public Archivo()
        {
            TipoArchivo = new HashSet<TipoArchivo>();
        }

        public int IdArchivo { get; set; }
        public byte[] Descripcion { get; set; }

        public virtual ICollection<TipoArchivo> TipoArchivo { get; set; }
    }
}
