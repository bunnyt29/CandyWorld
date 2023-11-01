using CandyWorld.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CandyWorld.Data
{
    public class CandyWorldDbContext : IdentityDbContext
    {
        public CandyWorldDbContext(DbContextOptions<CandyWorldDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bill> Bills { get; set; }

        public DbSet<CandyEmployee> CandyEmployees { get; set; }

        public DbSet<EmployeePosition> EmployeePositions { get; set; }


        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>()
                .HasKey(p => new { p.ProductId, p.ProductCategoryId, p.CandyEmployeeId });

            builder.Entity<Product>()
                .HasOne(p => p.ProductCategory)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.ProductCategoryId);

            builder.Entity<Product>()
                .HasOne(p => p.Chef)
                .WithMany(ch => ch.Products)
                .HasForeignKey(p => p.CandyEmployeeId);



            builder.Entity<Bill>()
                .HasKey(b => new { b.BillId, });

            builder.Entity<Bill>()
                .HasOne(b => b.CandyEmployee)
                .WithMany(ce => ce.Bills)
                .HasForeignKey(b => b.CandyEmployeeId);

            builder.Entity<Bill>()
                .HasOne(b => b.Product)
                .WithMany(p => p.Bills)
                .HasForeignKey(b => b.ProductId);



            builder.Entity<CandyEmployee>()
                .HasKey(ce => new {ce.CandyEmployeeId});

            builder.Entity<CandyEmployee>()
                .HasOne(ce => ce.Position) 
                .WithMany(p => p.Employees)
                .HasForeignKey(ce => ce.EmployeePositionId);



        }
    }
}