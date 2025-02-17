using Microsoft.EntityFrameworkCore;

namespace new1.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }

        public DbSet<Employee> employees { get; set; }
    }
}
