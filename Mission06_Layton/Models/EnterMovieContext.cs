using Microsoft.EntityFrameworkCore;

namespace Mission06_Layton.Models
{
    public class EnterMovieContext : DbContext
    {
        public EnterMovieContext(DbContextOptions<EnterMovieContext> options) : base(options) // Constructor
        {
        }

        public DbSet<Form> Movies { get; set; }
    }
}
