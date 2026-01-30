/// <summary>
/// Objeto de respuesta
/// </summary>
/// <typeparam name="T"></typeparam>
public class ApiResponse<T>
{
    /// <summary>
    /// Validacion de respuesta
    /// </summary>
    public bool Exito { get; set; }

    /// <summary>
    /// Mensaje de respuesta
    /// </summary>
    public string Mensaje { get; set; }

    /// <summary>
    /// Datos de respuesta
    /// </summary>
    public T Datos { get; set; }
}

