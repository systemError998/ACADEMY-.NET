using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ef_lez04_videoteca.Models;

public partial class EfLez04VideotecaContext : DbContext
{
    public EfLez04VideotecaContext()
    {
    }

    public EfLez04VideotecaContext(DbContextOptions<EfLez04VideotecaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Supporto> Supportos { get; set; }

    public virtual DbSet<Videoteca> Videotecas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ACADEMY2024-30\\SQLEXPRESS;Database=ef_lez04_videoteca;User Id=academy;Password=academy2024!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Supporto>(entity =>
        {
            entity.HasKey(e => e.SupportoId).HasName("PK__Supporto__DDE7A497B2B9D0A7");

            entity.ToTable("Supporto");

            entity.Property(e => e.SupportoId).HasColumnName("supportoID");
            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.Codice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codice");
            entity.Property(e => e.Disponibilita)
                .HasDefaultValue(true)
                .HasColumnName("disponibilita");
            entity.Property(e => e.Tipo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Titolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("titolo");
            entity.Property(e => e.VideotecaRif).HasColumnName("videotecaRIF");

            entity.HasOne(d => d.VideotecaRifNavigation).WithMany(p => p.Supportos)
                .HasForeignKey(d => d.VideotecaRif)
                .HasConstraintName("FK__Supporto__videot__3C69FB99");
        });

        modelBuilder.Entity<Videoteca>(entity =>
        {
            entity.HasKey(e => e.VideotecaId).HasName("PK__Videotec__B44B70FF555239FF");

            entity.ToTable("Videoteca");

            entity.Property(e => e.VideotecaId).HasColumnName("videotecaID");
            entity.Property(e => e.Codice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codice");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("indirizzo");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
