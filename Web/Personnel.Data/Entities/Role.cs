using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Personnel.Data
{
    [Table("mmcconnell.Role")]
    public class Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Role()
        {
            this.Employees = new HashSet<Employee>();
        }

        public int RoleID { get; set; }
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
