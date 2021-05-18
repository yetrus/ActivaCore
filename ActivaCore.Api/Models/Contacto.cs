using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class Contacto
    {
        public int IdContacto { get; set; }
        public int? IdEntidad { get; set; }

        public virtual Entidad IdEntidadNavigation { get; set; }
    }
}
