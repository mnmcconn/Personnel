using System;
using System.Collections.Generic;
using System.Linq;

namespace Personnel.Data
{
    public class EmployeeRepository : RepositoryBase<Employee>
    {
        public EmployeeRepository(DataContext DB) : base(DB) { }

        public List<Employee> GetEmployees(int ManagerID)
        {
            return db.Employees
                    .AsNoTracking()
                    .Where(e => e.ManagerID == ManagerID)
                    .ToList();
        }

        public List<Employee> GetManagers()
        {
            try
            {
                return db.Employees                    
                    .AsNoTracking()
                    .Where(e => e.Roles.Where(r => r.Description == Properties.Settings.Default.DirectorRole).Count() > 0)
                    .ToList();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message + Environment.NewLine + e.InnerException?.Message);
            }
            return new List<Employee>();
        }
    }
}