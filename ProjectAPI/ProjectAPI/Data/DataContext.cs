using Microsoft.EntityFrameworkCore;

namespace ProjectAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Project> Projects => Set<Project>();
    }
}
