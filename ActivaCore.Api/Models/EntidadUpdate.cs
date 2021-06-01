using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class EntidadUpdate
    {
        //public CreateEntidad()
        //{
        //    ContactoNavigation = new HashSet<Contacto>();
        //}
        public EntidadUpdate(int rut, string dv, string nombre, string apellido, string materno, string razon,
                            string direccion, int contacto, string telefono, string telefono2, string mail, int idTipo,
                            int idSubTipo, int idCategoria, int idEstado, int idEmpresa, int persona, int idComuna, string pass)
        {
            Rut = rut;
            Dv = dv;
            Nombre = nombre;
            Apellido = apellido;
            Materno = materno;
            Razon = razon;
            Direccion = direccion;
            Contacto = contacto;
            Telefono = telefono;
            Telefono2 = telefono2;
            Mail = mail;
            IdTipo = idTipo;
            IdSubTipo = idSubTipo;
            IdCategoria = idCategoria;
            IdEstado = idEstado;
            IdEmpresa = idEmpresa;
            Persona = persona;
            IdComuna = idComuna;
            Pass = pass;
        }

        public int IdEntidad { get; set; }
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
        //public byte[] Huella { get; set; }

        //public virtual Categoria IdCategoriaNavigation { get; set; }
        //public virtual AppComuna IdComunaNavigation { get; set; }
        //public virtual Estado IdEstadoNavigation { get; set; }
        //public virtual Tipo IdTipoNavigation { get; set; }
        //public virtual ICollection<Contacto> ContactoNavigation { get; set; }
    }
}
