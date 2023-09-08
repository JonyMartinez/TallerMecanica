using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TallerMecanica.Models;

public partial class TallerMecanicaContext : DbContext
{
    public TallerMecanicaContext()
    {
    }

    public TallerMecanicaContext(DbContextOptions<TallerMecanicaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Mecanico> Mecanicos { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=JONY_MARTINEZ\\SQLEXPRESS; Database=TallerMecanica; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__Clientes__71ABD0A7FDFD9C43");

            entity.Property(e => e.ClienteId)
                .ValueGeneratedNever()
                .HasColumnName("ClienteID");
            entity.Property(e => e.CorreoElectronico).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(200);
        });

        modelBuilder.Entity<Mecanico>(entity =>
        {
            entity.HasKey(e => e.MecanicoId).HasName("PK__Mecanico__D68834C12CF5E9CB");

            entity.Property(e => e.MecanicoId)
                .ValueGeneratedNever()
                .HasColumnName("MecanicoID");
            entity.Property(e => e.CorreoElectronico).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(200);
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.VehiculoId).HasName("PK__Vehiculo__AA0886203CEBFE32");

            entity.ToTable("Vehiculo");

            entity.Property(e => e.VehiculoId)
                .ValueGeneratedNever()
                .HasColumnName("VehiculoID");
            entity.Property(e => e.Color)
                .HasMaxLength(100)
                .HasColumnName("color");
            entity.Property(e => e.Marca).HasMaxLength(100);
            entity.Property(e => e.Placa).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
