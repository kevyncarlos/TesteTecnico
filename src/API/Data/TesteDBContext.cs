using API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class TesteDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public TesteDBContext(DbContextOptions<TesteDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>(x =>
            {
                x.HasKey(s => s.Id);
            });
        }
    }
}
