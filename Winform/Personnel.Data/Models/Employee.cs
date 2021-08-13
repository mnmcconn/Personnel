using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel.Data
{
    public partial class Employee
    {
        public string DisplayName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        // Get all managers - (NOTE: Managers are employees with the Director Role at S-Squared)
        public List<Employee> GetManagers()
        {
            using (PersonnelEntities db = new PersonnelEntities())
            {
                return db.Employees
                    .Where(e => e.Roles.Where(r => r.Description == Properties.Settings.Default.DirectorRole).Count() > 0).ToList();
            }
        }

        // Get all employees for a manager
        public List<Employee> GetEmployees(int ManagerID)
        {
            using (PersonnelEntities db = new PersonnelEntities())
            {
                return db.Employees
                    .Where(e => e.ManagerID == ManagerID).ToList();
            }
        }        
    }
}
