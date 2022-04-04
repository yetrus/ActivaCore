using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblStudent = new HashSet<TblStudent>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<TblStudent> TblStudent { get; set; }
    }
}
