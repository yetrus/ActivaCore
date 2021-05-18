using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class AppRegion
    {
        public AppRegion()
        {
            AppComuna = new HashSet<AppComuna>();
        }

        public int IdRegion { get; set; }
        public string NombreRegion { get; set; }

        public virtual ICollection<AppComuna> AppComuna { get; set; }
    }
}
