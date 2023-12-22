using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using UTB.Eshop.Domain.Entities;

namespace UTB.Eshop.Infrastructure.Database
{
    public class EshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public EshopDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DatabaseInit dbInit = new DatabaseInit();
            modelBuilder.Entity<Product>().HasData(dbInit.ProductInit());
        }
    }
}
