using System.ComponentModel.DataAnnotations;

namespace HoyNoCircula.Api.Models;

/// <summary>
/// Clase objeto vehiculo
/// </summary>
public class Vehiculo
{
    /// <summary>
    /// Atributo id
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Atributo placa
    /// </summary>
    [Required]
    public string Placa { get; set; } = string.Empty;

    /// <summary>
    /// Atributo color
    /// </summary>
    public string Color { get; set; } = string.Empty;

    /// <summary>
    /// Atributo modelo
    /// </summary>
    public string Modelo { get; set; } = string.Empty;

    /// <summary>
    /// Atributo marca
    /// </summary>
    public string Marca { get; set; } = string.Empty;

    /// <summary>
    /// Atributo chasis
    /// </summary>
    public string Chasis { get; set; } = string.Empty;

    /// <summary>
    /// Atributo year 
    /// </summary>
    public int Anio { get; set; }

    /// <summary>
    /// Atirbuto fecha de registro
    /// </summary>
    public DateTime fecha_registro { get; set; } = DateTime.UtcNow;
}