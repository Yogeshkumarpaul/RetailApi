using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RF.Models
{
    public partial class RetailContext : DbContext
    {
        public RetailContext()
        {
        }

        public RetailContext(DbContextOptions<RetailContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<TypeDetail> TypeDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=SONY-PC;initial catalog=Retail;integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__Accounts__349DA58662064638");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AddLine1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddLine2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddLine3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TinNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__B40CC6CD5B66A208");

                entity.Property(e => e.InitStock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MagUnitId).HasColumnName("MagUnitID");

                entity.Property(e => e.MarginAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MarginPer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Prate)
                    .HasColumnName("PRate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Srate)
                    .HasColumnName("SRate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SuitableFor)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<TypeDetail>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__TypeDeta__516F03B58AA9C82A");

                entity.Property(e => e.DetailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
