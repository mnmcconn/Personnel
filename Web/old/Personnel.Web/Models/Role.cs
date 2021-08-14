using System.Collections.Generic;
namespace Personnel.Data.Models
{
    public class Role
    {
        public Role()
        {
            this.Employees = new List<Employee>();
        }

        public virtual ICollection<Employee> Employees { get; set; }
    }

   
}