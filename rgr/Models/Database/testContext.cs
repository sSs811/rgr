using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace rgr.Models.Database
{
    public partial class testContext : DbContext
    {
        public testContext()
        {
        }

        public testContext(DbContextOptions<testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Horse> Horses { get; set; } = null!;
        public virtual DbSet<Ippodrom> Ippodroms { get; set; } = null!;
        public virtual DbSet<Jokey> Jokeys { get; set; } = null!;
        public virtual DbSet<Owner> Owners { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;
        public virtual DbSet<Trainer> Trainers { get; set; } = null!;
        public virtual DbSet<Zabeg> Zabegs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\kosty\\OneDrive\\Рабочий стол\\SQLiteStudio\\test.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Horse>(entity =>
            {
                entity.HasKey(e => e.NameHorse);

                entity.ToTable("horse");

                entity.Property(e => e.NameHorse).HasColumnName("name horse");

                entity.Property(e => e.Age)
                    .HasColumnType("INT")
                    .HasColumnName("age");

                entity.Property(e => e.Pol).HasColumnName("pol");

                entity.Property(e => e.Ves)
                    .HasColumnType("INT")
                    .HasColumnName("ves");
            });

            modelBuilder.Entity<Ippodrom>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("ippodrom");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Pokritie).HasColumnName("pokritie");
            });

            modelBuilder.Entity<Jokey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jokey");

                entity.Property(e => e.NameHorse).HasColumnName("name horse");

                entity.Property(e => e.NameJokey).HasColumnName("name jokey");

                entity.HasOne(d => d.NameHorseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NameHorse);
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("owner");

                entity.Property(e => e.NameHorse).HasColumnName("name horse");

                entity.Property(e => e.NameOwner).HasColumnName("name owner");

                entity.HasOne(d => d.NameHorseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NameHorse);
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("result");

                entity.Property(e => e.Finish).HasColumnName("finish");

                entity.Property(e => e.NameHorse).HasColumnName("name horse");

                entity.Property(e => e.Otstavanie).HasColumnName("otstavanie");

                entity.Property(e => e.Start)
                    .HasColumnType("INT")
                    .HasColumnName("start");

                entity.Property(e => e.Vid).HasColumnName("vid");

                entity.HasOne(d => d.NameHorseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NameHorse);

                entity.HasOne(d => d.VidNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Vid);
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trainer");

                entity.Property(e => e.NameHorse).HasColumnName("name horse");

                entity.Property(e => e.NameTrainer).HasColumnName("name trainer");

                entity.HasOne(d => d.NameHorseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NameHorse);
            });

            modelBuilder.Entity<Zabeg>(entity =>
            {
                entity.HasKey(e => e.Vid);

                entity.ToTable("zabeg");

                entity.Property(e => e.Vid).HasColumnName("vid");

                entity.Property(e => e.Data)
                    .HasColumnType("DATE")
                    .HasColumnName("data");

                entity.Property(e => e.Dist).HasColumnName("dist");

                entity.Property(e => e.Ippodrom).HasColumnName("ippodrom");

                entity.HasOne(d => d.IppodromNavigation)
                    .WithMany(p => p.Zabegs)
                    .HasForeignKey(d => d.Ippodrom);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
