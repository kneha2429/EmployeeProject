using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EM.Entities.Models
{
    public partial class Ukemployee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string RoleName { get; set; }
        public bool? ActiveInd { get; set; }
        public string MiddleName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? Salary { get; set; }
    }
}
