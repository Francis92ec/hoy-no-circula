import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrarVehiculoComponent } from './registrar-vehiculo';

describe('RegistrarVehiculo', () => {
  let component: RegistrarVehiculoComponent;
  let fixture: ComponentFixture<RegistrarVehiculoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RegistrarVehiculoComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegistrarVehiculoComponent);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
