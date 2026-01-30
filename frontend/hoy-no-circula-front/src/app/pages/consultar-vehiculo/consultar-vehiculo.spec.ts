import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultarVehiculoComponent } from './consultar-vehiculo';

describe('ConsultarVehiculo', () => {
  let component: ConsultarVehiculoComponent;
  let fixture: ComponentFixture<ConsultarVehiculoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ConsultarVehiculoComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConsultarVehiculoComponent);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
