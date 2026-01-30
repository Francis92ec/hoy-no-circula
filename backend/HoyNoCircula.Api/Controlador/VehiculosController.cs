using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HoyNoCircula.Api.Data;
using HoyNoCircula.Api.DTOs;
using HoyNoCircula.Api.Models;
using HoyNoCircula.Api.Services;

namespace HoyNoCircula.Api.Controllers;

/// <summary>
/// Clase controller
/// </summary>
[ApiController]
[Route("api/vehiculos")]
public class VehiculosController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IHoyNoCirculaService _service;

    public VehiculosController(ApplicationDbContext context, IHoyNoCirculaService service)
    {
        _context = context;
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> CrearVehiculo([FromBody] VehiculoRequestDto dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new ApiResponse<object>
            {
                Exito = false,
                Mensaje = "Datos inválidos",
                Datos = ModelState
            });
        }

        var existe = await _context.Vehiculos.AnyAsync(v => v.Placa == dto.Placa);
        if (existe)
        {
            return Conflict(new ApiResponse<object>
            {
                Exito = false,
                Mensaje = "La placa ya se encuentra registrada"
            });
        }

        var vehiculo = new Vehiculo
        {
            Placa = dto.Placa,
            Marca = dto.Marca,
            Modelo = dto.Modelo,
            Color = dto.Color,
            Chasis = dto.Chasis,
            Anio = dto.Anio,
            fecha_registro = DateTime.Now
        };

        _context.Vehiculos.Add(vehiculo);
        await _context.SaveChangesAsync();

        var response = new VehiculoResponseDto
        {
            Id = vehiculo.Id,
            Placa = vehiculo.Placa,
            Marca = vehiculo.Marca,
            Modelo = vehiculo.Modelo
        };

        return Ok(new ApiResponse<VehiculoResponseDto>
        {
            Exito = true,
            Mensaje = "El vehículo fue registrado correctamente.",
            Datos = response
        });
    }


    [HttpPost("consulta")]
    public async Task<IActionResult> Consultar(ConsultaRequestDto dto)
    {
        if (dto.FechaHoraConsulta.Date < DateTime.Now.Date)
            return Ok(new ConsultaResponseDto
                {
                    Mensaje = "La fecha no puede ser anterior a la fecha actual."
                });

        var vehiculo = await _context.Vehiculos
            .FirstOrDefaultAsync(v => v.Placa == dto.Placa);

        if (vehiculo == null)
            return Ok(new ConsultaResponseDto
            {
                Mensaje = "Vehículo no registrado."
            });

        bool puedeCircular = _service.PuedeCircular(dto.Placa, dto.FechaHoraConsulta);

        var consulta = new Consulta
        {
            Placa = dto.Placa,
            FechaConsulta = dto.FechaHoraConsulta,
            PuedeCircular = puedeCircular,
            Mensaje = puedeCircular
                ? "El vehículo PUEDE circular."
                : "El vehículo NO PUEDE circular en la fecha y hora indicada."
        };

        try
        {
            _context.Consultas.Add(consulta);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new
            {
                error = ex.InnerException?.Message ?? ex.Message
            });
        }

        return Ok(new ConsultaResponseDto
        {
            Vehiculo = vehiculo,
            PuedeCircular = puedeCircular,
            Mensaje = consulta.Mensaje
        });
    }


}
