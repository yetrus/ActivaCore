using System;
using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public partial class TblStudent
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public bool? IsDeleted { get; set; }
        public int? DepartmentId { get; set; }

        public virtual TblDepartment Department { get; set; }
    }
}
