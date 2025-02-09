using Microsoft.EntityFrameworkCore;

namespace to_do.Classes
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> option) : base(option) 
        {
            
        }

        public DbSet<Usuario> usuarios { get; set; }
    }
}
