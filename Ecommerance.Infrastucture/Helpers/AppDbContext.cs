using Ecommerance.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerance.Infrastucture.Helpers
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<Product> Product { get; protected set; }
        public DbSet<Color> Color{ get; set; }
        public DbSet<ProductFoto> ProductFoto { get; protected set; }
        public DbSet<Size> Size { get; protected set; }
        public DbSet<ProductDefinition> ProductDefinition { get; protected set; }
        public DbSet<ProductAvailability> ProductAvailability { get; protected set; }
        public DbSet<User> Users { get; protected set; }
        private Guid productDefinitionID = Guid.NewGuid();
        private Guid productID= Guid.NewGuid();
        private Guid ProductAvailabilityID = Guid.NewGuid();
        private Guid productColorID = Guid.NewGuid();
        private Guid categoryId = Guid.NewGuid();
        private Guid ColorID = Guid.NewGuid();
        private Guid SizeID = Guid.NewGuid();
        private Guid ColorZielonyID = Guid.NewGuid();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<User>().HasData(new User ( Guid.NewGuid(), "admin", "admin", "admin", "admin@wp.pl", "t@blet2009"));
           
            modelBuilder.Entity<Size>().HasData(new Size(SizeID,"S","rozmiar S",""));
            modelBuilder.Entity<Color>().HasData(new Color(ColorID,"Żółty","jasno żółty","#2423","/color.jpg"));
            modelBuilder.Entity<ProductDefinition>().HasData(new ProductDefinition(productDefinitionID,"Koszulka Stussy","Bawełniana koszulka z nadrukiem","Stussy","2020 summer",1));
            modelBuilder.Entity<Category>().HasData(new Category(categoryId, "Koszulki",Guid.Empty));
            modelBuilder.Entity<Product>().HasData(new Product(productID,1,0,"żółty","S",productDefinitionID, SizeID,ColorID,categoryId,109));
            modelBuilder.Entity<ProductAvailability>().HasData(new ProductAvailability(ProductAvailabilityID, 10,productID));
            modelBuilder.Entity<ProductFoto>().HasData(new ProductFoto(Guid.NewGuid(),productID,productDefinitionID, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/syjv2pftag56ak1oy7mx/meska-domowa-koszulka-pilkarska-fc-Q8x1XQ.jpg","Koszulka nike",1));
        }
    }
}
