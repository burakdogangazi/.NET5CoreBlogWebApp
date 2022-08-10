using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class ApiContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=BlogApiDb;integrated security=true;");

        }

        public DbSet<Employee> Employees { get; set; }

    }
}
