import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class VehiculoService {

  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  consultarHoyNoCircula(data: any) {
    return this.http.post(`${this.apiUrl}/vehiculos/consulta`, data);
  }

  registrarVehiculo(data: any) {
    return this.http.post(`${this.apiUrl}/vehiculos`, data);
  }
}
