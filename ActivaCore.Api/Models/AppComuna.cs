using System;
using System.Collections.Generic;

namespace ActivaCore.Api.Models
{
    public partial class AppComuna
    {
        public AppComuna()
        {
            Entidad = new HashSet<Entidad>();
        }

        public int IdComuna { get; set; }
        public int? IdRegion { get; set; }
        public string CodigoArea { get; set; }
        public string NombreComuna { get; set; }

        public virtual AppRegion IdRegionNavigation { get; set; }
        public virtual ICollection<Entidad> Entidad { get; set; }
    }
}
