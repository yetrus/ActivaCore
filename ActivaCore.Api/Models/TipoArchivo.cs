﻿using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class TipoArchivo
    {
        public int IdTipoArchivo { get; set; }
        public int? IdArchivo { get; set; }
        public int? IdTipo { get; set; }

        public virtual Archivo IdArchivoNavigation { get; set; }
    }
}
