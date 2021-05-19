using ActivaCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace ActivaCore.Repository
{
    public class ActivaContext : DbContext
    {
        public ActivaContext(DbContextOptions<ActivaContext> options) : base(options)
        {

        }

        // Entities
        //public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
