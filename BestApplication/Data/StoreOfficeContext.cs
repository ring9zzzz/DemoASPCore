using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BestApplication.Data
{
    public partial class StoreOfficeContext : DbContext
    {     
        public StoreOfficeContext(DbContextOptions<StoreOfficeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Guarantees> Guarantees { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<ProductDetails> ProductDetails { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Promotions> Promotions { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.CategoryCode)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Guarantees>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.GuaranteeName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.GuaranteeTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Manufacturers>(entity =>
            {
                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ManufacturerCode)
                    .IsRequired()
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");
            });

            modelBuilder.Entity<ProductDetails>(entity =>
            {
                entity.Property(e => e.DateOfManufacture).HasColumnType("date");

                entity.Property(e => e.FullName).HasMaxLength(350);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Link).IsRequired();

                entity.Property(e => e.ModifiedBy).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ProductName).IsRequired();
            });

            modelBuilder.Entity<Promotions>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.PromotionName)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.PromotionTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalPrice).HasColumnType("money");
            });
        }
    }
}