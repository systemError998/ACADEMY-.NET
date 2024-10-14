using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace rest_04_ef_videoteche.Models;

public partial class Lez04LibreriaContext : DbContext
{
    public Lez04LibreriaContext()
    {
    }

    public Lez04LibreriaContext(DbContextOptions<Lez04LibreriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ACADEMY2024-30\\SQLEXPRESS;Database=lez04_libreria;User Id=academy;Password=academy2024!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.IdLibro).HasName("PK__Libro__5BC0F0268603072C");

            entity.ToTable("Libro");

            entity.HasIndex(e => e.Isbn, "UQ__Libro__99F9D0A47AFFA172").IsUnique();

            entity.Property(e => e.IdLibro).HasColumnName("idLibro");
            entity.Property(e => e.Autore)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("autore");
            entity.Property(e => e.Editor)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("N.D")
                .HasColumnName("editor");
            entity.Property(e => e.Isbn)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isbn");
            entity.Property(e => e.Pagine)
                .HasDefaultValue(1)
                .HasColumnName("pagine");
            entity.Property(e => e.Titolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("titolo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
