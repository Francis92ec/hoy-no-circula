using System.ComponentModel.DataAnnotations;
namespace HoyNoCircula.Api.DTOs;

/// <summary>
/// Clase vehiculo dto de peticion
/// </summary>
public class VehiculoRequestDto
{
    /// <summary>
    /// Atributo placa del vehiculo
    /// </summary>
    [Required]
    [MaxLength(10)]
    public string Placa { get; set; }

    /// <summary>
    /// Atributo marca del vehiculo
    /// </summary>
    [Required]
    public string Marca { get; set; }


    /// <summary>
    /// Atributo modelo 
    /// </summary>
    [Required]
    public string Modelo { get; set; }

    /// <summary>
    /// Atributo color
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    /// Atributo chasis
    /// </summary>
    public string? Chasis { get; set; }

    /// <summary>
    /// Fecha del vehiculo
    /// </summary>
    public int Anio { get; set; }
}

