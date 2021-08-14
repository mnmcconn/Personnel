using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personnel.Data
{
    [Table("mmcconnell.Employee")]
    public class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Roles = new HashSet<Role>();
        }

        public int EmployeeID { get; set; }
        public int? ManagerID { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Roles { get; set; }

        public string DisplayName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

    }
}
