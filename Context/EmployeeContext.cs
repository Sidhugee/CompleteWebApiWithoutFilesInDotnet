using Microsoft.EntityFrameworkCore;
using WebApiWithoutFiles.Models;

namespace WebApiWithoutFiles.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
