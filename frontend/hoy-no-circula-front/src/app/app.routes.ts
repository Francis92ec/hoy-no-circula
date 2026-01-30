import { Routes } from '@angular/router';
import { ConsultarVehiculoComponent } from './pages/consultar-vehiculo/consultar-vehiculo';
import { RegistrarVehiculoComponent} from './pages/registrar-vehiculo/registrar-vehiculo';

export const routes: Routes = [
  { path: 'consultar', component: ConsultarVehiculoComponent },
  { path: 'registrar', component: RegistrarVehiculoComponent },
  { path: '', redirectTo: 'consultar', pathMatch: 'full' }
];
