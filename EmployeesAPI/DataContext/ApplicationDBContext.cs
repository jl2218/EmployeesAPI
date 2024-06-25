using EmployeesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesAPI.DataContext
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
