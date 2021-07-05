using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ActivaCore.Api.Models
{
    public partial class ActivaContext : DbContext
    {
        public ActivaContext()
        {
        }

        public ActivaContext(DbContextOptions<ActivaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tipo> Tipo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DEATHSTAR\\SQLEXPRESS;Database=Activa;User ID=Anakin;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__Tipo_Doc__1367E606");

                entity.HasIndex(e => e.IdTipo)
                    .HasName("UQ__Tipo_Doc__145C0A3F")
                    .IsUnique();

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.FechaEdicion).HasColumnType("date");

                entity.Property(e => e.IdSubTipo).HasColumnName("Id_SubTipo");
            });
        }
    }
}
