using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class AppMenu
    {
        public int IdMenu { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }
        public int? IdCabeceraMenu { get; set; }
        public int IdCategoria { get; set; }
        public string Ruta { get; set; }
    }
}
