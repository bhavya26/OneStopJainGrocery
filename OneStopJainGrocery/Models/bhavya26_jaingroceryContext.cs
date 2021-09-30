using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OneStopJainGrocery.Models
{
    public partial class bhavya26_jaingroceryContext : DbContext
    {
        public bhavya26_jaingroceryContext()
        {
        }

        public bhavya26_jaingroceryContext(DbContextOptions<bhavya26_jaingroceryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Diet> Diets { get; set; }
        public virtual DbSet<GroceryItem> GroceryItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=198.38.83.200;Database=bhavya26_jaingrocery;Uid=bhavya26_jaingroceryadmin;pwd=h@rrypotter26");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("bhavya26_jaingroceryadmin")
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Categories)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("categories");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.Countryname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("countryname");
            });

            modelBuilder.Entity<Diet>(entity =>
            {
                entity.ToTable("diet");

                entity.Property(e => e.DietType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dietType");
            });

            modelBuilder.Entity<GroceryItem>(entity =>
            {
                entity.Property(e => e.Categories).HasColumnName("categories");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.DietType).HasColumnName("dietType");

                entity.Property(e => e.Productimage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("productimage");

                entity.Property(e => e.Productname)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("productname");

                entity.Property(e => e.Producturl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("producturl");

                entity.HasOne(d => d.CategoriesNavigation)
                    .WithMany(p => p.GroceryItems)
                    .HasForeignKey(d => d.Categories)
                    .HasConstraintName("FK__GroceryIt__categ__38996AB5");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.GroceryItems)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK__GroceryIt__count__3A81B327");

                entity.HasOne(d => d.DietTypeNavigation)
                    .WithMany(p => p.GroceryItems)
                    .HasForeignKey(d => d.DietType)
                    .HasConstraintName("FK__GroceryIt__dietT__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
