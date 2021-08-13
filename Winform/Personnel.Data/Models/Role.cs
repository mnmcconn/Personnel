using System.Collections.Generic;
using System.Linq;

namespace Personnel.Data
{
    public partial class Role
    {
        public List<Role> GetRoles()
        {
            using (PersonnelEntities db = new PersonnelEntities())
            {
                return db.Roles.ToList();
            }
        }
    }
}
