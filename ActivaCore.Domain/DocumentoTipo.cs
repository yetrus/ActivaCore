using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class DocumentoTipo
    {
        public DocumentoTipo()
        {
            Documento = new HashSet<Documento>();
        }

        public int IdTipo { get; set; }
        public string TipoDocumento { get; set; }

        public virtual ICollection<Documento> Documento { get; set; }
    }
}
