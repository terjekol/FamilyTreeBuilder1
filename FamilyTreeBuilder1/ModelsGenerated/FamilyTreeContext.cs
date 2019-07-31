using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FamilyTreeBuilder1.ModelsGenerated
{
    public partial class FamilyTreeContext : DbContext
    {
        public FamilyTreeContext()
        {
        }

        public FamilyTreeContext(DbContextOptions<FamilyTreeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("host=localhost;database=FamilyTree;user id=postgres;password=abcd1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.Deathdate)
                    .HasColumnName("deathdate")
                    .HasColumnType("date");

                entity.Property(e => e.Father).HasColumnName("father");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Ismale).HasColumnName("ismale");

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Mother).HasColumnName("mother");

                entity.HasOne(d => d.FatherNavigation)
                    .WithMany(p => p.InverseFatherNavigation)
                    .HasForeignKey(d => d.Father)
                    .HasConstraintName("person_father_fkey");

                entity.HasOne(d => d.MotherNavigation)
                    .WithMany(p => p.InverseMotherNavigation)
                    .HasForeignKey(d => d.Mother)
                    .HasConstraintName("person_mother_fkey");
            });
        }
    }
}
