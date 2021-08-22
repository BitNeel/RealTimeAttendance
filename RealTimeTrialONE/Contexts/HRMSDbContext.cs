using Microsoft.EntityFrameworkCore;
using RealTimeTrialONE.api.Models;

namespace RealTimeTrialONE.api.Contexts
{
    public class HRMSDbContext : DbContext
    {
        public HRMSDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
    }
}
