using System.Data.Entity;

namespace Personnel.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("PersonnelEntities")
        {
            //disable initializer
            Database.SetInitializer<DataContext>(null);
            this.Configuration.LazyLoadingEnabled = false;
            this.Database.CommandTimeout = 300;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("mmcconnell");
            modelBuilder.Entity<Employee>()
                .HasMany(p => p.Roles)
                    .WithMany(c => c.Employees)
                .Map(manyToMany => manyToMany
                    .ToTable("EmployeeRole", "mmcconnell")
                    .MapLeftKey("EmployeeID")
                    .MapRightKey("RoleID"));
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}