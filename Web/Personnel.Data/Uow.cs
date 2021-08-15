using System;

namespace Personnel.Data
{

    public class Uow : IDisposable
    {
        //----------------------------------
        public DataContext db = null;
        //----------------------------------
        public EmployeeRepository Employees { get; set; }
        public RoleRepository Roles { get; set; }

        public Uow(DataContext DB)
        {

            if (db == null)
                db = DB;
       
            Employees = new EmployeeRepository(db);
            Roles = new RoleRepository(db);
       
        }
        public void Commit()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }      
}
