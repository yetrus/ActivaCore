using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class EntidadCreate
    {
        //public CreateEntidad()
        //{
        //    ContactoNavigation = new HashSet<Contacto>();
        //}

        //public int IdEntidad { get; set; }
        public int Rut { get; set; }
        public string Dv { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Materno { get; set; }
        public string Razon { get; set; }
        public string Direccion { get; set; }
        public int? Contacto { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Mail { get; set; }
        public int? IdTipo { get; set; }
        public int? IdSubTipo { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdEstado { get; set; }
        public int? IdEmpresa { get; set; }
        public int? Persona { get; set; }
        public int? IdComuna { get; set; }
        public string Pass { get; set; }
        public byte[] Huella { get; set; }

        //public virtual Categoria IdCategoriaNavigation { get; set; }
        //public virtual AppComuna IdComunaNavigation { get; set; }
        //public virtual Estado IdEstadoNavigation { get; set; }
        //public virtual Tipo IdTipoNavigation { get; set; }
        //public virtual ICollection<Contacto> ContactoNavigation { get; set; }
    }
}
