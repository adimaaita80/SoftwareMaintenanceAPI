using Microsoft.EntityFrameworkCore;

namespace SoftwareMaintenanceAPI.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options) : base(options) 
        { 
        }

        // Add the entity collections for your tables here
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
