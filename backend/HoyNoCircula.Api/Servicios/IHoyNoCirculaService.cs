namespace HoyNoCircula.Api.Services;

/// <summary>
/// Clase de interfaz de no circula servicio
/// </summary>
public interface IHoyNoCirculaService
{
    /// <summary>
    /// Metodo de consultar si puede circular
    /// </summary>
    /// <param name="placa">Placa del vehiculo</param>
    /// <param name="fechaHora">fecha de consulta</param>
    /// <returns>Retorno de informacion</returns>
    bool PuedeCircular(string placa, DateTime fechaHora);
}
