using DiskVinil.Entities;
using Microsoft.EntityFrameworkCore;

namespace DiskVinil.Context
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> opt) : base(opt){
        }
        public DbSet<Disco> discos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        
    }
}
