using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDTesteMeta.Models
{
    public class TrucksContext : DbContext
    {
        public TrucksContext(DbContextOptions<TrucksContext> options) : base(options)
        {

        }
        public DbSet<Trucks> Truks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trucks>(entity =>
            {
                entity.Property(e => e.TrukModel).IsRequired().HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.TrukManufacturingYear).IsRequired().HasMaxLength(10).IsUnicode(false);
                entity.Property(e => e.TrukModelYear).IsRequired().HasMaxLength(10).IsUnicode(false);
            });
        }
    }
}
