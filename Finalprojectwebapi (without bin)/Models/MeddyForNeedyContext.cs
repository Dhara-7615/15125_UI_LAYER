using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Finalprojectwebapi.Models
{
    public partial class MeddyForNeedyContext : DbContext
    {
        public MeddyForNeedyContext()
        {
        }

        public MeddyForNeedyContext(DbContextOptions<MeddyForNeedyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Meddy-For-Needy;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("imagepath");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ProductNAME");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.Property(e => e.DeviceId).ValueGeneratedNever();

                entity.Property(e => e.Brand)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DeviceNAME");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("imagepath");
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.MedicineId).ValueGeneratedNever();

                entity.Property(e => e.Diesese)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Dosage)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("imagepath");

                entity.Property(e => e.MedicalStoreName)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.MedicineName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MedicineNAME");

                entity.Property(e => e.PackaginingSize)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Userpassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERPASSWORD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
