using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class Tipo
    {
        public int IdTipo { get; set; }
        public string Descripcion { get; set; }
        public int? IdSubTipo { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaEdicion { get; set; }
        public int? UsuarioCreacion { get; set; }
        public int? UsuarioEdicion { get; set; }
    }
}
