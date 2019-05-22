using CrudBackend.Data;
using Microsoft.EntityFrameworkCore;

namespace CrudBackend
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Person> Persons { get; set; }
    }
}
