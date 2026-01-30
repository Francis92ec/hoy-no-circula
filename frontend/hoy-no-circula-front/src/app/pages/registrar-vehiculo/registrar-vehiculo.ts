import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { VehiculoService } from '../../core/service/vehiculo.service'
declare var bootstrap: any;
@Component({
  selector: 'app-registrar-vehiculo',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './registrar-vehiculo.html',
  styleUrls: ['./registrar-vehiculo.css'],
})
export class RegistrarVehiculoComponent {

vehiculo = {
    placa: '',
    marca: '',
    modelo: '',
    color: '',
    chasis: '',
    anio: 0
  };

  mensaje = '';

  constructor(private vehiculoService: VehiculoService) {}

  registrar() {
    this.vehiculoService.registrarVehiculo(this.vehiculo).subscribe({
      next: () => {
        this.mensaje = 'Vehículo registrado correctamente';
        this.mostrarModal();
        this.limpiarFormulario();
      },
      error: (err) => {
        this.mensaje = err?.error || 'Error al registrar vehículo';
        this.mostrarModal();
      }
    });
  }

  limpiarFormulario() {
    this.vehiculo = {
    placa: '',
    marca: '',
    modelo: '',
    color: '',
    chasis: '',
    anio: 0
    };
  }

  mostrarModal() {
    const modal = new bootstrap.Modal(
      document.getElementById('resultadoModal')
    );
    modal.show();
  }
}
