using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CsgoStrats.Models
{
    public partial class CsgostratsdbContext : DbContext
    {
        public CsgostratsdbContext()
        {
        }

        public CsgostratsdbContext(DbContextOptions<CsgostratsdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Strat> Strats { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8MEGL96\\SQLEXPRESS; Database=Csgostratsdb; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Strat>(entity =>
            {
                entity.Property(e => e.StratId).HasColumnName("stratId");

                entity.Property(e => e.StratDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("stratDescription");

                entity.Property(e => e.StratMap)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("stratMap");

                entity.Property(e => e.StratSide)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("stratSide");

                entity.Property(e => e.StratTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("stratTitle");

                entity.Property(e => e.StratVideoLink)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("stratVideoLink");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
