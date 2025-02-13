using Microsoft.EntityFrameworkCore;

namespace Mission06_Layton.Models
{

    // Allows for the creation of a database context
    public class EnterMovieContext : DbContext
    {
        public EnterMovieContext(DbContextOptions<EnterMovieContext> options) : base(options) // Constructor
        {
        }

        // Movies table is created with the Form model
        public DbSet<Form> Movies { get; set; }
    }
}
