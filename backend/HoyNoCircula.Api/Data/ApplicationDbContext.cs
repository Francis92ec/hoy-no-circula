using HoyNoCircula.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace HoyNoCircula.Api.Data;


/// <summary>
/// Clase  Conexion a la base de datos
/// </summary>
public class ApplicationDbContext : DbContext
{
    /// <summary>
    /// Constructor de clase
    /// </summary>
    /// <param name="options"></param>
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    /// <summary>
    /// Modelo del dataset clase vehiculos
    /// </summary>
    public DbSet<Vehiculo> Vehiculos => Set<Vehiculo>();

    /// <summary>
    /// Modleo de dataset clase consultas
    /// </summary>
    public DbSet<Consulta> Consultas { get; set; }

    /// <summary>
    /// Configura la columna 'Placa' como un índice único para evitar duplicados.
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vehiculo>()
            .HasIndex(v => v.Placa)
            .IsUnique();
    }
}
