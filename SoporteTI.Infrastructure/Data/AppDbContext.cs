using Microsoft.EntityFrameworkCore;
using SoporteTI.Domain.Entities;

namespace SoporteTI.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tb_Ticket> Tb_Ticket { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
