namespace HoyNoCircula.Api.DTOs;

/// <summary>
/// Clase Dto de ingreso de consulta del vehiculo
/// </summary>
public class ConsultaRequestDto
{
    /// <summary>
    /// Atributo de consulta placa tipo string
    /// </summary>
    public string Placa { get; set; } = string.Empty;

    /// <summary>
    /// Atributo de fecha consulta tipo fecha
    /// </summary>
    public DateTime FechaHoraConsulta { get; set; }
}
