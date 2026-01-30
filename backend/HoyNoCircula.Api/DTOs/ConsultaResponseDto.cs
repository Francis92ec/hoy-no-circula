using HoyNoCircula.Api.Models;
namespace HoyNoCircula.Api.DTOs;

/// <summary>
/// Clase dto consulta response
/// </summary>
public class ConsultaResponseDto
{
    /// <summary>
    /// Modelo vehiculo
    /// </summary>
    public Vehiculo Vehiculo { get; set; } = null!;

    /// <summary>
    /// Atributo boliano para validacion de circulacion
    /// </summary>
    public bool PuedeCircular { get; set; }

    /// <summary>
    /// Mensaje de respuesta
    /// </summary>
    public string Mensaje { get; set; } = string.Empty;
}
