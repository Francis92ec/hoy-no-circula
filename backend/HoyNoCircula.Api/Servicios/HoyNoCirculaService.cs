namespace HoyNoCircula.Api.Services;

/// <summary>
/// Clase servicio de hoy no circula
/// </summary>
public class HoyNoCirculaService : IHoyNoCirculaService
{
    /// <summary>
    /// Implementacion
    /// </summary>
    /// <param name="placa"></param>
    /// <param name="fechaHora"></param>
    /// <returns></returns>
    public bool PuedeCircular(string placa, DateTime fechaHora)
    {
        int ultimoDigito = int.Parse(placa[^1].ToString());
        var dia = fechaHora.DayOfWeek;
        var hora = fechaHora.TimeOfDay;

        bool horarioRestriccion =
            (hora >= new TimeSpan(7, 0, 0) && hora <= new TimeSpan(9, 30, 0)) ||
            (hora >= new TimeSpan(16, 0, 0) && hora <= new TimeSpan(19, 30, 0));

        if (!horarioRestriccion)
            return true;

        return dia switch
        {
            DayOfWeek.Monday => ultimoDigito is < 1 or > 2,
            DayOfWeek.Tuesday => ultimoDigito is < 3 or > 4,
            DayOfWeek.Wednesday => ultimoDigito is < 5 or > 6,
            DayOfWeek.Thursday => ultimoDigito is < 7 or > 8,
            DayOfWeek.Friday => ultimoDigito != 9 && ultimoDigito != 0,
            _ => true
        };
    }
}
