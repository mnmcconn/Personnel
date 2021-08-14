using System.Collections.Generic;

namespace Personnel.Data.Models
{
    public class Employee
    {
        public Employee()
        {
            this.Roles = new List<Role>();
        }

        public virtual ICollection<Role> Roles { get; set; }
    }
}