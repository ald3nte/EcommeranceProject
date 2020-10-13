
using EcommeranceWebApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EcommeranceWebApp.Helpers
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; protected set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<ProductFoto> ProductFoto { get; protected set; }
        public DbSet<Size> Size { get; protected set; }
        public DbSet<ProductDefinition> ProductDefinition { get; protected set; }
        public DbSet<ProductAvailability> ProductAvailability { get; protected set; }
        public DbSet<User> Users { get; protected set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
