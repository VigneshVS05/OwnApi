using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ImageWebapi.Models;

public partial class ImagesssContext : DbContext
{
    public ImagesssContext()
    {
    }

    public ImagesssContext(DbContextOptions<ImagesssContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Imagesss> Imagessses { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    
}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Author");

            entity.Property(e => e.AFirstname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("A_Firstname");
            entity.Property(e => e.AId)
                .ValueGeneratedOnAdd()
                .HasColumnName("A_id");
            entity.Property(e => e.ALastname)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("A_Lastname");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BAuthourid).HasColumnName("B_authourid");
            entity.Property(e => e.BId)
                .ValueGeneratedOnAdd()
                .HasColumnName("B_id");
            entity.Property(e => e.BTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("B_title");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("customer");

            entity.Property(e => e.FavoriteWebsite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("favorite_website");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_name");
        });

        modelBuilder.Entity<Imagesss>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PK__imagesss__3CAC591108500403");

            entity.ToTable("imagesss");

            entity.Property(e => e.ImageId).HasColumnName("Image_id");
            entity.Property(e => e.Categories)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.ImageAttributes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Image_Attributes");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(2083)
                .IsUnicode(false)
                .HasColumnName("Image_URL");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("orders");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("order_date");
            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("order_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
