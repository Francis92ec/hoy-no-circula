using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Clase objeto consulta
/// </summary>
[Table("consultas")]
public class Consulta
{
    /// <summary>
    /// Atributo id
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Atributo placa
    /// </summary>
    public string Placa { get; set; }

    /// <summary>
    /// Atributo fecha de consulta
    /// </summary>
    [Column("fecha_consulta")]
    public DateTime FechaConsulta { get; set; }

    /// <summary>
    /// Atributo de validacion de circulacion 
    /// </summary>
    [Column("puede_circular")]
    public bool PuedeCircular { get; set; }

    /// <summary>
    /// Mensaje 
    /// </summary>
    public string Mensaje { get; set; }

}