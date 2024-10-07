using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models.Entities;


namespace EmployeeManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
