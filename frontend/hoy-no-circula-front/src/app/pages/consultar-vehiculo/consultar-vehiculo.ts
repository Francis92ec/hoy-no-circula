import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { VehiculoService } from '../../core/service/vehiculo.service'
declare var bootstrap: any;
@Component({
  selector: 'app-consultar-vehiculo',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './consultar-vehiculo.html',
  styleUrls: ['./consultar-vehiculo.css'],
})
export class ConsultarVehiculoComponent {

  placa: string = '';
  fechaHoraConsulta: string = '';
  resultado: any = null;

  constructor(private vehiculoService: VehiculoService) {}

  consultar() {
    const request = {
      placa: this.placa,
      fechaHoraConsulta: this.fechaHoraConsulta
    };

    this.vehiculoService.consultarHoyNoCircula(request)
      .subscribe({
        next: (res) => {
          this.resultado = res;
        },
        error: (err) => {
          this.mostrarModalNoRegistrado();
        }
      });
  }
    mostrarModalNoRegistrado() {
    const modalElement = document.getElementById(
      'vehiculoNoRegistradoModal'
    );
    const modal = new bootstrap.Modal(modalElement);
    modal.show();
  }
    nuevaConsulta() {
    this.placa = '';
    this.fechaHoraConsulta = '';
    this.resultado = null;
  }

}
