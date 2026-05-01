using Microsoft.EntityFrameworkCore;

namespace FirstMVC.Models
{
    public class ITIContext : DbContext 
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        
        public ITIContext() : base() // empty constructor Vs Dependency Injection
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Data Source=DESKTOP-BII5KT0;Initial Catalog=Assiut_DotNet_Q3;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
