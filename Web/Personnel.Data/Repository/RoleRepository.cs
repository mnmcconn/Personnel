using System.Collections.Generic;
using System.Linq;

namespace Personnel.Data
{
    public class RoleRepository : RepositoryBase<Employee>
    {
        public RoleRepository(DataContext DB) : base(DB) { }

        public List<Role> GetRoles()
        {
            return db.Roles.ToList();
        }       
    }
}